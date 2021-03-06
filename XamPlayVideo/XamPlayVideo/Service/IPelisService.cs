namespace XamPlayVideo.Service
{
    using System.Collections.Generic;
    using XamPlayVideo.Model;

    public interface IPelisService
    {
        List<Movie> GetMovies();

        void SetFeatured(int id);
    }
}
