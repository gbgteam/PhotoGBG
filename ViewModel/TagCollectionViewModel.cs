using DataAccessAbstraction.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModel.Others;
using AutoMapper;
using DataAccess.Entities;

namespace ViewModel
{
    public class TagCollectionViewModel : BaseViewModel
    {
        public List<TagViewModel> Tags { get; set; }

        public TagCollectionViewModel()
        {
            Tags = new List<TagViewModel>();
        }

        public TagCollectionViewModel(List<ITag> list)
        {
            Tags = new List<TagViewModel>();
            if (list != null)
            {
                foreach (ITag tag in list)
                {
                    TagViewModel tagVM = new TagViewModel(tag);
                    Tags.Add(tagVM);
                }
            }
        }
    }
}
