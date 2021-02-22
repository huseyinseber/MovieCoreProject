using System.Collections.Generic;
using System.Linq;
using MovieApp.Models;

namespace MovieApp.Data
{
    public class MovieRepository
    {
        private static List<Movie> _movies = null;
        static MovieRepository()
        {
            _movies = new List<Movie>()
            {
                
                new Movie(){
                 Id=1,
                 Name="breakingbad",
                 Description="<p>Lorem ipsum, dolor sit amet consectetur adipisicing elit. Adipisci molestias tempore cumque facilis fuga quidem, doloremque quo quasi atque quia accusamus neque! Soluta repellat id ad sed, maxime nihil quaerat.</p>",
                 ShortDescription="breakingbad",
                 ImageUrl="breakingbad.jpg",
                 CategoryId=1
                 },
                new Movie(){
                 Id=2,
                 Name="code8",
                  Description="<p>Lorem ipsum, dolor sit amet consectetur adipisicing elit. Adipisci molestias tempore cumque facilis fuga quidem, doloremque quo quasi atque quia accusamus neque! Soluta repellat id ad sed, maxime nihil quaerat.</p>",
                  ShortDescription="code8",
                 ImageUrl="code8.jpg",
                  CategoryId=2
                  },
                new Movie(){
                 Id=3,
                 Name="joker",
                    Description="<p>Lorem ipsum, dolor sit amet consectetur adipisicing elit. Adipisci molestias tempore cumque facilis fuga quidem, doloremque quo quasi atque quia accusamus neque! Soluta repellat id ad sed, maxime nihil quaerat.</p>",
                 ShortDescription="joker",
                 ImageUrl="joker.jpg",
                 CategoryId=1
                 },
                new Movie()
                {
                    Id=4, 
                    Name="reddot",
                    Description="<p>Lorem ipsum, dolor sit amet consectetur adipisicing elit. Adipisci molestias tempore cumque facilis fuga quidem, doloremque quo quasi atque quia accusamus neque! Soluta repellat id ad sed, maxime nihil quaerat.</p>",
                    ShortDescription="reddot",
                    ImageUrl="reddot.jpg",
                    CategoryId=2
                },
                new Movie(){
                    Id=5, 
                    Name="taxi2",
                   Description="<p>Lorem ipsum, dolor sit amet consectetur adipisicing elit. Adipisci molestias tempore cumque facilis fuga quidem, doloremque quo quasi atque quia accusamus neque! Soluta repellat id ad sed, maxime nihil quaerat.</p>",
                     ShortDescription="taxi2",
                    ImageUrl="taxi2.jpg",
                    CategoryId=5
                    }
            };
        }


        public static List<Movie> Movies
        {
            get
            {
                return _movies;
            }
        }

        public static void AddMovie(Movie entity)
        {
            _movies.Add(entity);
        }

        public static Movie GetById(int id)
        {
            return _movies.FirstOrDefault(i => i.Id == id);
        }




    }
}