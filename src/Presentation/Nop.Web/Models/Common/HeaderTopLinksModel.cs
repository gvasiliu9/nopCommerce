namespace Nop.Web.Models.Common;

public class HeaderTopLinksModel
{
    public string PhoneNumber { get; set; }

    public IEnumerable<TopicModel> Topics { get; set; }

    #region Nested

    public class TopicModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string SeName { get; set; }
    }

    #endregion
}


