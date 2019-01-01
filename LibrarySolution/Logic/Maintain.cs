using System;
using System.Collections.Generic;

namespace LibrarySolution
{
    public class Maintain
    {
        private Data data;

        public Boolean rentItem(Item item, Reader reader)
        {
            data = new Data();
            if (!data.retriveAvailableBooks())
            {
                return false;
            }
            List<Book> availableBooks = data.getAvailableBooks();
            Boolean check = false;
            
            foreach(var book in availableBooks)
            {
                if (book.id == item.id)
                {
                    check = true;
                    break;
                }
            }

            if (check)
            {
                Renting renting = new Renting(reader.id, item.id);
                data.addRenting(renting);
                return true;
            }
            else  return false;
        }
        
    }
}