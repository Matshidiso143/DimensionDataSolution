using System;

namespace DimensionData.Models
{
    public class ErrorViewModel
    {
        public string RequestId { get; set; }
        public string Age { get; set; }


        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
