namespace HungerZone.Web.Utility
{
    /// <summary>
    /// The staticdetails class contains all statics members
    /// </summary>
    public class StaticDetails
    {
        public static string CouponApiBase { get; set; }
        public enum ApiType
        {
            GET,
                POST,
                PUT,DELETE,
        }
    }
}
