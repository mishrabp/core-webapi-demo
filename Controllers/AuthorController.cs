using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

/****IT IS A TEST CONTROLLER CLASS FOR LEARNING************/

namespace corewebapidemo.Controllers
{
    //[Route("api/[controller]")]
    //[Route("[controller]/[action]")]
    [ApiController]
    public class AuthorController : ControllerBase
    {
        //URL: https://localhost:5001/api/getall
        [Route("api/getall")]
        [Route("[controller]/[action]")]
        public string GetAll()
        {
            return "View everything.";
        }

        //URL: https://localhost:5001/api/authors
        //[Route("api/authors")]
        //public string GetAllAuthors()
        //{
        //    return "View all the authors.";
        //}

        //URL: https://localhost:5001/api/authors/1 
        [Route("api/authors/{id}")]
        public string GetById( int id)
        {
            return $"View the author: {id}";
        }

        //URL: https://localhost:5001/api/authors/1/books/5
        [Route("api/authors/{id}/books/{bookId}")]
        public string GetAuthorBookById(int id, int bookId)
        {
            return $"View the author: {id} & his book: {bookId}";
        }

        //URL: https://localhost:5001/api/authors?id=4&bookid=5&bookNAME=raghh&rating=4
        //URL: https://localhost:5001/authors?id=4&bookid=5&bookNAME=raghh&rating=4
        [Route("api/authors")]
        [Route("authors")]
        public string SearchAuthor(int id, int bookId, string bookName, int rating)
        {
            return $"View the author: {id} & his book: {bookId} : Book Name: {bookName} : Rating: {rating}";
        }
    }
}