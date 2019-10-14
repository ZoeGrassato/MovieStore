using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using OnlineMovieStoreV2.Models;

namespace OnlineMovieStoreV2.ViewModels
{
    public class CustomerFormViewModel
    {
        public IEnumerable<MembershipType> MembershipTypes { get; set; }
        public Customer Customer { get; set; }
    }
}