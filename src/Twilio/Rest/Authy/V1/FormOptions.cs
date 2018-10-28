/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /

using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Converters;

namespace Twilio.Rest.Authy.V1 
{

    /// <summary>
    /// PLEASE NOTE that this class contains preview products that are subject to change. Use them with caution. If you
    /// currently do not have developer preview access, please contact help@twilio.com.
    /// 
    /// Fetch the forms for a specific form type.
    /// </summary>
    public class FetchFormOptions : IOptions<FormResource> 
    {
        /// <summary>
        /// The Form Type of this Form
        /// </summary>
        public FormResource.FormTypeEnum PathFormType { get; }

        /// <summary>
        /// Construct a new FetchFormOptions
        /// </summary>
        /// <param name="pathFormType"> The Form Type of this Form </param>
        public FetchFormOptions(FormResource.FormTypeEnum pathFormType)
        {
            PathFormType = pathFormType;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            return p;
        }
    }

}