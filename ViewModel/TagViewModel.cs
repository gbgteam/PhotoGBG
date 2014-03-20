using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModel.Others;
using AutoMapper;
using DataAccessAbstraction.Entities;

namespace ViewModel
{
    public class TagViewModel : BaseViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string AddedBy { get; set; }

        public void Build()
        {
            Mapper.CreateMap<ITag, TagViewModel>();
            Mapper.CreateMap<TagViewModel, ITag>()
                .ForMember(d => d.Id, opt => opt.MapFrom(src => src.Id));
            Mapper.CreateMap<TagViewModel, ITag>()
                .ForMember(d => d.Name, opt => opt.MapFrom(src => src.Name));
            Mapper.CreateMap<TagViewModel, ITag>()
                .ForMember(d => d.AddedBy, opt => opt.MapFrom(src => src.AddedBy));

        }

        public TagViewModel(ITag tag)
        {
            this.Id = tag.Id;
            this.Name = tag.Name;
            this.AddedBy = tag.AddedBy;
        }
    }
}
