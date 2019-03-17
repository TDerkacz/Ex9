using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using MyWebApp.Models;

namespace MyWebApp.Services
{
    public class PersonalNotesService
    {
        private static IList<PersonalNote> Notes = new List<PersonalNote>
        {
            new PersonalNote
            {
                Id = 1,
                DueDate = new DateTime(2019, 2, 17),
                Priority = 5,
                Content = "Some content 1"
            },
            new PersonalNote
            {
                Id = 2,
                DueDate = new DateTime(2019, 2, 21),
                Priority = 1,
                Content = "Some content 2"
            },
            new PersonalNote
            {
                Id = 3,
                DueDate = new DateTime(2019, 2, 20),
                Priority = 2,
                Content = "Some content 3"
            },
            new PersonalNote
            {
                Id = 4,
                DueDate = new DateTime(2019, 2, 19),
                Priority = 3,
                Content = "Some content 3"
            }
        };

        public IList<PersonalNote> GetAll()
        {
            return Notes;
        }

        public PersonalNote GetById(int id)
        {
            return Notes.Single(x => x.Id == id);
        }

        public PersonalNote Create(PersonalNote personalNote)
        {
            personalNote.Id = Notes.Max(note => note.Id) + 1;
            Notes.Add(personalNote);
            return personalNote;
        }

        // De facto to to nie kasuje, tylko nadpisuje liste nową listą bez danego elementu, ale wychodzi na to samo :)
        public IList<PersonalNote> Delete(int id)
        {
            return Notes = Notes.Where(x => x.Id != id).ToList();
        }
    }
}