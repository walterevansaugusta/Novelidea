using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace BrainyStories
{
    
    class TableOfContentsModel
    {
        public ObservableCollection<Story> Stories { get; set; }
        public TableOfContentsModel()
        {
            
        }
    }
}
