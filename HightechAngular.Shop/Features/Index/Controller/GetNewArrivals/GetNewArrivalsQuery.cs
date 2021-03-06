﻿using System.Linq;
using Force.Cqrs;

namespace HightechAngular.Shop.Features.Index.Controller.GetNewArrivals
{
    public class GetNewArrivalsQuery: FilterQuery<GetNewArrivalsListItem>
    {
        public override IOrderedQueryable<GetNewArrivalsListItem> Sort(IQueryable<GetNewArrivalsListItem> queryable)
        {
            if (Order == "dateCreated")
            {
                return Asc ? queryable.OrderByDescending(x => x.DateCreated) : queryable.OrderBy(x => x.DateCreated);
            }
            return base.Sort(queryable);
        }
    }
}