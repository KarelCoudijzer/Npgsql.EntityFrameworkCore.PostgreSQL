﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.TestUtilities;
using Npgsql.EntityFrameworkCore.PostgreSQL.TestUtilities;
using Xunit.Abstractions;

namespace Npgsql.EntityFrameworkCore.PostgreSQL
{
    // Disabled upstream
    internal class TableSplittingNpgsqlTest : TableSplittingTestBase
    {
        public TableSplittingNpgsqlTest(ITestOutputHelper testOutputHelper)
            : base(testOutputHelper)
        {
        }

        protected override ITestStoreFactory TestStoreFactory => NpgsqlTestStoreFactory.Instance;
    }
}
