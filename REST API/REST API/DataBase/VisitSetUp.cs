using REST_API.Models;

namespace REST_API.Database;

public static  class VisitSetUp
{
    public static List<Visit> Visits = new List<Visit>()
    {
        { new Visit(DateTime.Now, 1,"cold",78.9)},
        { new Visit(DateTime.Now, 1,"much better",28.9)},
        { new Visit(DateTime.Now, 3,"furloss",178.8)}
        
    };
}