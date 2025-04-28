using ElectionBoard.Models.Domain;

namespace ElectionBoard.Persistence;

public static class ElectionDbContextSeedData
{
    public static IList<State> GetStates()
    {
        
         return new List<State>
        { 
            new State {  FipsCode = "01", Name = "Alabama", ElectoralVotes = 9 },
            new State {FipsCode = "02", Name = "Alaska", ElectoralVotes = 3 },
            new State {FipsCode = "04", Name = "Arizona", ElectoralVotes = 11 },
            new State {FipsCode = "05", Name = "Arkansas", ElectoralVotes = 6 },
            new State {FipsCode = "06", Name = "California", ElectoralVotes = 55 },
            new State {FipsCode = "08", Name = "Colorado", ElectoralVotes = 9 },
            new State {FipsCode = "09", Name = "Connecticut", ElectoralVotes = 7 },
            new State {FipsCode = "10", Name = "Delaware", ElectoralVotes = 3 },
            new State {FipsCode = "12", Name = "Florida", ElectoralVotes = 29 },
            new State { FipsCode = "13", Name = "Georgia", ElectoralVotes = 16 },
            new State { FipsCode = "15", Name = "Hawaii", ElectoralVotes = 4 },
            new State { FipsCode = "16", Name = "Idaho", ElectoralVotes = 4 },
            new State { FipsCode = "17", Name = "Illinois", ElectoralVotes = 20 },
            new State { FipsCode = "18", Name = "Indiana", ElectoralVotes = 11 },
            new State { FipsCode = "19", Name = "Iowa", ElectoralVotes = 6 },
            new State { FipsCode = "20", Name = "Kansas", ElectoralVotes = 6 },
            new State { FipsCode = "21", Name = "Kentucky", ElectoralVotes = 8 },
            new State { FipsCode = "22", Name = "Louisiana", ElectoralVotes = 8 },
            new State { FipsCode = "23", Name = "Maine", ElectoralVotes = 4 },
            new State { FipsCode = "24", Name = "Maryland", ElectoralVotes = 10 },
            new State { FipsCode = "25", Name = "Massachusetts", ElectoralVotes = 11 },
            new State { FipsCode = "26", Name = "Michigan", ElectoralVotes = 16 },
            new State { FipsCode = "27", Name = "Minnesota", ElectoralVotes = 10 },
            new State { FipsCode = "28", Name = "Mississippi", ElectoralVotes = 6 },
            new State { FipsCode = "29", Name = "Missouri", ElectoralVotes = 10 },
            new State { FipsCode = "30", Name = "Montana", ElectoralVotes = 3 },
            new State { FipsCode = "31", Name = "Nebraska", ElectoralVotes = 5 },
            new State { FipsCode = "32", Name = "Nevada", ElectoralVotes = 6 },
            new State { FipsCode = "33", Name = "New Hampshire", ElectoralVotes = 4 },
            new State { FipsCode = "34", Name = "New Jersey", ElectoralVotes = 14 },
            new State { FipsCode = "35", Name = "New Mexico", ElectoralVotes = 5 },
            new State { FipsCode = "36", Name = "New York", ElectoralVotes = 29 },
            new State { FipsCode = "37", Name = "North Carolina", ElectoralVotes = 15 },
            new State { FipsCode = "38", Name = "North Dakota", ElectoralVotes = 3 },
            new State { FipsCode = "39", Name = "Ohio", ElectoralVotes = 18 },
            new State { FipsCode = "40", Name = "Oklahoma", ElectoralVotes = 7 },
            new State { FipsCode = "41", Name = "Oregon", ElectoralVotes = 7 },
            new State { FipsCode = "42", Name = "Pennsylvania", ElectoralVotes = 20 },
            new State { FipsCode = "44", Name = "Rhode Island", ElectoralVotes = 4 },
            new State { FipsCode = "45", Name = "South Carolina", ElectoralVotes = 9 },
            new State { FipsCode = "46", Name = "South Dakota", ElectoralVotes = 3 },
            new State { FipsCode = "47", Name = "Tennessee", ElectoralVotes = 11 },
            new State { FipsCode = "48", Name = "Texas", ElectoralVotes = 38 },
            new State { FipsCode = "49", Name = "Utah", ElectoralVotes = 6 },
            new State { FipsCode = "50", Name = "Vermont", ElectoralVotes = 3 },
            new State { FipsCode = "51", Name = "Virginia", ElectoralVotes = 13 },
            new State { FipsCode = "53", Name = "Washington", ElectoralVotes = 12 },
            new State { FipsCode = "54", Name = "West Virginia", ElectoralVotes = 5 },
            new State { FipsCode = "55", Name = "Wisconsin", ElectoralVotes = 10 },
            new State { FipsCode = "56", Name = "Wyoming", ElectoralVotes = 3 }
        };
    } 
}