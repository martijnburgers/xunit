using System;
using System.Collections.Generic;
using System.Reflection;

namespace Xunit.Abstractions
{
    /// <summary>
    /// Represents a single test case in the system. This test case usually represents a single test, but in
    /// the case of dynamically generated data for data driven tests, the test case may actually return
    /// multiple results when run.
    /// </summary>
    public interface ITestCase
    {
        /// <summary>
        /// Gets the class that this test case resides in, if known. May return <c>null</c> for tests
        /// which are discovered without the use of reflection.
        /// </summary>
        [Obsolete]
        Type Class { get; }

        /// <summary>
        /// Gets the fully qualified type name of the class that this test case resides in.
        /// </summary>
        string ClassName { get; }

        /// <summary>
        /// Gets the display name of the test method.
        /// </summary>
        string DisplayName { get; }

        /// <summary>
        /// Gets the method that this test case resides in, if known. May return <c>null</c> for tests
        /// which are discovered without the use of reflection.
        /// </summary>
        [Obsolete]
        MethodInfo Method { get; }

        /// <summary>
        /// Gets the name of the method that this test case resides in.
        /// </summary>
        string MethodName { get; }

        /// <summary>
        /// Gets the display text for the reason a test is being skipped; if the test
        /// is not skipped, returns null.
        /// </summary>
        string SkipReason { get; }

        /// <summary>
        /// Get the source file line where the test is defined, if requested (and known).
        /// </summary>
        int? SourceFileLine { get; }

        /// <summary>
        /// Gets the source file name where the test is defined, if requested (and known).
        /// </summary>
        string SourceFileName { get; }

        /// <summary>
        /// Gets the test collection this test case belongs to.
        /// </summary>
        ITestCollection TestCollection { get; }

        /// <summary>
        /// Gets the trait values associated with this test case. If
        /// there are none, or the framework does not support traits,
        /// this should return an empty dictionary (not null). This
        /// dictionary should be treated as read-only.
        /// </summary>
        IDictionary<string, string> Traits { get; }
    }
}