using MobileClient.Model__Logic_;
using System;
using System.Collections.Generic;
using System.Text;

namespace MobileClient.ViewModel__Abstract_UI_
{
    public class PostVM
    {
        public List<Post> Posts { get; set; }

        public PostVM()
        {
            Posts = new Post().GetPosts();
        }
    }
}
