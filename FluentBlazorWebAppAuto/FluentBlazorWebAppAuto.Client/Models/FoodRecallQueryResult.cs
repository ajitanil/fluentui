namespace FluentBlazorWebAppAuto
{
    public class FoodRecallQueryResult
    {
        public Meta Meta { get; set; }
        public List<FoodRecall> Results { get; set; }
    }

    public class FoodRecall

    {
        public string country { get; set; }
        public string city { get; set; }
        public string status { get; set; }
       
    }

    public class MetaResult

    {
        public int Skip { get; set; }
        public int Limit { get; set; }
        public int Total { get; set; }

    }

    public class Meta
    {
        public string disclaimer { get; set; }
        public string terms { get; set; }
        public string license { get; set; }
        public string last_updated { get; set; }
        public MetaResult Results { get; set; }
    }

    public class InviteUserModel
    {
        public string UserGroupId { get; set; }
        public string PrimaryEmail { get; set; }
    }


    }
