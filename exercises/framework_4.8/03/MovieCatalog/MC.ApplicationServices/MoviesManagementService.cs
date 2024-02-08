﻿using MC.ApplicationServices.DTOs;
using MC.ApplicationServices.Helpers;
using System.Collections.Generic;
using System.Linq;

namespace MC.ApplicationServices
{
    public class MoviesManagementService : BaseManagementService
    {
        public IEnumerable<MovieDto> GetAll()
        {
            return _context.Movies.Include("Genre").Include("Director").AsNoTracking().AsEnumerable().ToMovieDtos();
        }

        public int Save(MovieDto movieDto)
        {
            try
            {
                _context.Movies.Add(movieDto.ToMovieEntity());
                _context.SaveChanges();
                return 1;
            }
            catch (System.Exception)
            {
                return -1;
            }
        }

        public int Delete(int id)
        {
            try
            {
                var movie = _context.Movies.Find(id);
                if (movie == null)
                    return -1;

                _context.Movies.Remove(movie);
                _context.SaveChanges();
                return 1;
            }
            catch (System.Exception)
            {
                return -1;
            }
        }
    }
}
