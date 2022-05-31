using System;
namespace ToDoApp
{
    public class contactCard
    {

        public string tittle;
        public string content;
        public int personId;
        public string size;

        public string Tittle { get => tittle; set => tittle = value; }
        public string Content { get => content; set => content = value; }
        public int PersonId { get => personId; set => personId = value; }
        public string Size { get => size; set => size = value; }

        public contactCard(string Tittle, string Content, int PersonId, string Size)
        {
            this.tittle = Tittle;
            this.content = Content;
            this.personId = PersonId;
            this.Size = Size;
        }

        public contactCard()
        {

        }


    }
}
