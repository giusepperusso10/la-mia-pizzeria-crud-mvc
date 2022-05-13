using NetCore_01.Models;

namespace NetCore_01.Utils
{
    public static class PostData
    {

        private static List<Post> posts;

        public static List<Post> GetPosts()
        {
            if(PostData.posts != null)
            {
                return PostData.posts;
            }

            List<Post> nuovaListaPosts = new List<Post>();

            for(int i=0; i<1; i++)
            {
                Post post = new Post(i, "Titolo post: " + i, "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.", "https://picsum.photos/id/" + i + "/300/200");
                nuovaListaPosts.Add(post);
            }

            PostData.posts = nuovaListaPosts;

            return PostData.posts;

        }

    }
}
