﻿using CWWebStore.Domain.Entities;
using CWWebStoreSharedKernel.Validation;

namespace CWWebStore.Domain.Scopes
{
    public static class CategoryScopes
    {
        public static bool CreateCategoryScopeIsValid(this Category category)
        {
            return AssertionConcern.IsSatisfiedBy
            (
                AssertionConcern.AssertNotEmpty(category.Title, "O título é obrigatório")
            );
        }

        public static bool EditCategoryScopeIsValid(this Category category, string title)
        {
            return AssertionConcern.IsSatisfiedBy
            (
                AssertionConcern.AssertNotEmpty(title, "O título é obrigatório")
            );
        }
    }
}
