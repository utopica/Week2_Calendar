using Week_2_Calendar.Entities;

Console.WriteLine("YetGen Calendar");

Meeting meeting1 = new()
{
    Title = "Yetgen Jump & Akbank Backend Program Planning Meeting ",
    Details = new() {
        "Participants enrolling process",
        "The mail from Akbank",
        "Budget planning"
    },
    StartTime = new DateTime(2023, 09, 20, 21, 00, 00),
    EndTime = new DateTime(2023, 09, 20, 22, 00, 00),
    Guests = new() { "a@gmail.com,b@gmail.com,c@gmail.com" }


};

Todo todo1 = new()
{
    Title = "Providing feedback to participants ",
    Details = new List<string>()
    {
        "Creating graphics"
    },
    StartTime = new DateTime(2023, 09, 20, 21, 00, 00),
    EndTime = new DateTime(2023, 09, 20, 22, 00, 00),
    Importance = "High Priority",


};

meeting1.GetNotification();
todo1.GetNotification();