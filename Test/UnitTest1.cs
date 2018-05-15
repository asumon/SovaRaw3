using SovaApi.Controllers;
using System.Linq;
using Xunit;
using SovaDataBase;
using System.Collections;
using System.Collections.Generic;

namespace Test
{

    public class UnitTest1
    {
        
        [Fact]
        public void Test1()
        {
            var controllers = new ValuesController();
            var result = controllers.Get();
            Assert.Equal(2, result.Count());

        }
        [Fact]
        public void CheckPostsNumber()
        {
            
            var postService = new PostService();
            var checkPost = postService.GetAllPost();
            Assert.Equal(2237, checkPost.Count());

        }
        [Fact]
        public void CheckUserNameById()
        {
            
            var userService = new UserServices();
            var UserById = userService.GetUserById(1).ToList();
            Assert.Equal("Jeff Atwood", UserById[0].Name);
        }
        [Fact]
        public void CheckUserPost()
        {

            var PostService = new PostService();
            var PostById = PostService.GetPostById(19).ToList();
            Assert.Equal(164, PostById[0].Score);

        }


        [Fact]
        public void KeySearchMustReturnSearchResults()
        {

            var ss = new SearchService();
            var result = ss.GetSearchResult("what is abs");
            Assert.Equal(1, result.Count());

        }

    }
}
