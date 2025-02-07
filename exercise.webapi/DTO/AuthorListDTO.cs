﻿namespace exercise.webapi.DTO
{
    public class AuthorListDTO
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public List<BookListDTO> BookList { get; set; } = new List<BookListDTO>();

    }
}
