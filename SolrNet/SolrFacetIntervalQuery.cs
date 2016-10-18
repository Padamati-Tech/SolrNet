
using System.Collections.Generic;

namespace SolrNet
{
    /// <summary>
    /// Facet field query
    /// </summary>
	public class SolrFacetIntervalQuery : ISolrFacetQuery //SolrFacetFieldQuery
    {
        private readonly string field;

        /// <summary>
        /// Creates a Interval facet query
        /// </summary>
        /// <param name="field">Field to facet</param>
        public SolrFacetIntervalQuery(string field)
        {
            this.field = field;
            this.Set = new List<string>();
        }

        /// <summary>
        /// Creates a Interval facet query
        /// </summary>
        /// <param name="field">Field to facet</param>
        /// <param name="set">Field to set intervals</param>
        public SolrFacetIntervalQuery(string field, List<string> set)
        {
            this.field = field;
            this.Set = set;
        }

        /// <summary>
        /// Facet field
        /// </summary>
	    public string Field
        {
            get { return field; }
        }

        /// <summary>
        /// Indicates that in addition to the counts for each date range constraint between start and end, counts should also be computed for other
        /// </summary>
        public ICollection<string> Set { get; set; }
        //public string Prefix { get; set; }

        /// <summary>
        /// Set to true, this parameter indicates that constraints should be sorted by their count. 
        /// If false, facets will be in their natural index order (unicode). 
        /// For terms in the ascii range, this will be alphabetically sorted. 
        /// The default is true if Limit is greater than 0, false otherwise.
        /// </summary>
        public bool? Sort { get; set; }

        /// <summary>
        /// This param indicates the maximum number of constraint counts that should be returned for the facet fields. 
        /// A negative value means unlimited. 
        /// The default value is 100. 
        /// </summary>
        public int? Limit { get; set; }

        /// <summary>
        /// This param indicates the minimum counts for facet fields should be included in the response.
        /// The default value is 0.
        /// </summary>
        public int? MinCount { get; set; }

        /// <summary>
        /// Set to true this param indicates that in addition to the Term based constraints of a facet field, a count of all matching results which have no value for the field should be computed
        /// Default is false
        /// </summary>
        public bool? Missing { get; set; }

        /// <summary>
        /// This param indicates the minimum document frequency (number of documents matching a term) for which the filterCache should be used when determining the constraint count for that term. 
        /// This is only used during the term enumeration method of faceting (field type faceting on multi-valued or full-text fields).
        /// A value greater than zero will decrease memory usage of the filterCache, but increase the query time. 
        /// When faceting on a field with a very large number of terms, and you wish to decrease memory usage, try a low value of 25 to 50 first.
        /// The default value is 0, causing the filterCache to be used for all terms in the field.
        /// </summary>
        public int? EnumCacheMinDf { get; set; }

    }
}
