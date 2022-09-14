using _0_Framework.Application;
using _0_Framework.Infrastructure;
using Haidarieh.Application.Contracts.Member;
using Haidarieh.Domain.MemberAgg;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Haidarieh.Infrastructure.EFCore.Repository
{
    public class MemberRepository : RepositoryBase<long, Member>, IMemberRepository
    {
        private readonly HContext _hContext;
        public MemberRepository(HContext hContext) : base(hContext)
        {
            _hContext = hContext;
        }
        public EditMember GetDetail(long id)
        {
            return _hContext.Members.Select(x => new EditMember()
            {
                Id = x.Id,
                FullName = x.FullName,
                Mobile = Int32.Parse(x.Mobile).ToPersianNumber()
            }).FirstOrDefault(x => x.Id == id);
        }

        public List<MemberViewModel> Search(MemberSearchModel searchModel)
        {
            var query = _hContext.Members.Select(x => new MemberViewModel
            {
                Id = x.Id,
                FullName = x.FullName,
                Mobile = Int64.Parse(x.Mobile).ToPersianNumber()
            });

            if (!string.IsNullOrWhiteSpace(searchModel.FullName))
                query = query.Where(x => x.FullName.Contains(searchModel.FullName));

            return query.OrderByDescending(x => x.Id).ToList();
        }
    }
}
