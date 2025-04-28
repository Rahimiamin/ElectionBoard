using FluentValidation;

namespace ElectionBoard.EndPoints;

public record CreateElectionBoardRequest(int ElectionCycle,List<ElectionBoardVoteItem> VoteItems);

public record ElectionBoardVoteItem(string Code, string Name, long Vote,string FipsCode);


public sealed class CreateElectionBoradRequestValidator : AbstractValidator<CreateElectionBoardRequest>
{
    public CreateElectionBoradRequestValidator()
    {
        RuleFor(x => x.ElectionCycle)
            .GreaterThan(2000).WithMessage("Election Cycle must be greater than 2000")
            .Must(c=> (c%4) ==0).WithMessage("Election Cycle must be divided by 4");
    }
}