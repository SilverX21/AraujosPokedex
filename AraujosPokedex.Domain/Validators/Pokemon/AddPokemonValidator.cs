using AraujosPokedex.Domain.Contracts;
using FluentValidation;

namespace AraujosPokedex.Domain.Validators.Pokemon;

public class AddPokemonValidator : AbstractValidator<AddPokemonRequest>
{
    public AddPokemonValidator()
    {
        RuleFor(x => x.Name)
            .NotNull().WithMessage("The Pokemón name can't be null.")
            .NotEmpty().WithMessage("Please add a Pokémon name")
            .MaximumLength(20).WithMessage("The Pokémon Name can't be more than 20 characters");

        RuleFor(x => x.NickName)
            .MaximumLength(20).WithMessage("The Pokémon Nickname can't be more than 20 characters");

        // If caught, date is required
        When(x => x.IsCaught is true, () =>
        {
            RuleFor(x => x.DateCaught)
                .NotNull()
                .WithMessage("DateCaught is required when the Pokémon is caught.")
                .LessThanOrEqualTo(_ => DateTime.UtcNow)
                .WithMessage("DateCaught cannot be in the future.");
        });

        // Optional: if not caught, date must be null (keeps data consistent)
        When(x => x.IsCaught is false, () =>
        {
            RuleFor(x => x.DateCaught)
                .Null()
                .WithMessage("DateCaught must be null when the Pokémon is not caught.");
        });
    }
}