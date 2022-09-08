﻿namespace RepositoryPatternDemo.DAL.Repositories
{
    using System.Linq;
    using RepositoryPatternDemo.DAL.UnitOfWork;
    using RepositoryPatternDemo.Entity.Entities;

    /// <summary>
    /// Provides members to manage Product Category Relation in database.
    /// </summary>
    public class ProductCategoryRelationRepository : BaseRepository<ProductCategoryRelation>, IProductCategoryRelationRepository
    {
        #region Constructors

        /// <summary>
        /// Sets db context using Unit of Work.
        /// </summary>
        /// <param name="context">Unit of work</param>
        public ProductCategoryRelationRepository(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        #endregion Constructors

        #region Public Methods

        /// <summary>
        /// Gets Product Category Relation table query.
        /// </summary>
        /// <param name="isTrackingRequired">Whether tracking is required or not in db entity</param>
        /// <returns>Product table</returns>
        public IQueryable<ProductCategoryRelation> GetQueryableProductCategoryRelations(bool isTrackingRequired = true)
        {
            IQueryable<ProductCategoryRelation> result = null;

            if (isTrackingRequired)
            {
                result = Table.Where(k => k.IsActive);
            }
            else
            {
                result = TableWithNoTracking.Where(k => k.IsActive);
            }

            return result;
        }

        #endregion Public Methods
    }
}
