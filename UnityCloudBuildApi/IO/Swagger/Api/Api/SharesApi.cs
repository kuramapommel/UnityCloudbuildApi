using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using UnityCloudBuildApi.IO.Swagger.Client;
using UnityCloudBuildApi.IO.Swagger.Model;
using static UnityCloudBuildApi.Encode;

namespace UnityCloudBuildApi.IO.Swagger.Api
{
    
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ISharesApi
    {
        
        /// <summary>
        /// Get details on shared build including download link
        /// </summary>
        /// <remarks>
        /// This is an endpoint accessible without an api key that provides information about a\nspecific build including download links.\nA shareid is generated by POSTing to a &lt;a href=\&quot;#!/builds/createShare\&quot;&gt;build&#39;s share endpoint&lt;/a&gt;.
        /// </remarks>
        /// <param name="shareid"></param>
        /// <param name="include">Extra fields to include in the response</param>
        /// <returns>OrgsorgidprojectsprojectidbuildtargetsBuilds</returns>
        OrgsorgidprojectsprojectidbuildtargetsBuilds GetShareMetadata (string shareid, string include = null);
  
        /// <summary>
        /// Get details on shared build including download link
        /// </summary>
        /// <remarks>
        /// This is an endpoint accessible without an api key that provides information about a\nspecific build including download links.\nA shareid is generated by POSTing to a &lt;a href=\&quot;#!/builds/createShare\&quot;&gt;build&#39;s share endpoint&lt;/a&gt;.
        /// </remarks>
        /// <param name="shareid"></param>
        /// <param name="include">Extra fields to include in the response</param>
        /// <returns>ApiResponse of OrgsorgidprojectsprojectidbuildtargetsBuilds</returns>
        ApiResponse<OrgsorgidprojectsprojectidbuildtargetsBuilds> GetShareMetadataWithHttpInfo (string shareid, string include = null);

        /// <summary>
        /// Get details on shared build including download link
        /// </summary>
        /// <remarks>
        /// This is an endpoint accessible without an api key that provides information about a\nspecific build including download links.\nA shareid is generated by POSTing to a &lt;a href=\&quot;#!/builds/createShare\&quot;&gt;build&#39;s share endpoint&lt;/a&gt;.
        /// </remarks>
        /// <param name="shareid"></param>
        /// <param name="include">Extra fields to include in the response</param>
        /// <returns>Task of OrgsorgidprojectsprojectidbuildtargetsBuilds</returns>
        System.Threading.Tasks.Task<OrgsorgidprojectsprojectidbuildtargetsBuilds> GetShareMetadataAsync (string shareid, string include = null);

        /// <summary>
        /// Get details on shared build including download link
        /// </summary>
        /// <remarks>
        /// This is an endpoint accessible without an api key that provides information about a\nspecific build including download links.\nA shareid is generated by POSTing to a &lt;a href=\&quot;#!/builds/createShare\&quot;&gt;build&#39;s share endpoint&lt;/a&gt;.
        /// </remarks>
        /// <param name="shareid"></param>
        /// <param name="include">Extra fields to include in the response</param>
        /// <returns>Task of ApiResponse (OrgsorgidprojectsprojectidbuildtargetsBuilds)</returns>
        System.Threading.Tasks.Task<ApiResponse<OrgsorgidprojectsprojectidbuildtargetsBuilds>> GetShareMetadataAsyncWithHttpInfo (string shareid, string include = null);
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class SharesApi : ISharesApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SharesApi"/> class.
        /// </summary>
        /// <returns></returns>
        public SharesApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="SharesApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public SharesApi(Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = Configuration.Default; 
            else
                this.Configuration = configuration;
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'Configuraiton.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(String basePath)
        {
            // do nothing
        }
    
        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Configuration Configuration {get; set;}

        /// <summary>
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
        public Dictionary<String, String> DefaultHeader()
        {
            return this.Configuration.DefaultHeader;
        }

        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        [Obsolete("AddDefaultHeader is deprecated, please use Configuration.AddDefaultHeader instead.")]
        public void AddDefaultHeader(string key, string value)
        {
            this.Configuration.AddDefaultHeader(key, value);
        }
   
        
        /// <summary>
        /// Get details on shared build including download link This is an endpoint accessible without an api key that provides information about a\nspecific build including download links.\nA shareid is generated by POSTing to a &lt;a href=\&quot;#!/builds/createShare\&quot;&gt;build&#39;s share endpoint&lt;/a&gt;.
        /// </summary>
        /// <param name="shareid"></param> 
        /// <param name="include">Extra fields to include in the response</param> 
        /// <returns>OrgsorgidprojectsprojectidbuildtargetsBuilds</returns>
        public OrgsorgidprojectsprojectidbuildtargetsBuilds GetShareMetadata (string shareid, string include = null)
        {
             ApiResponse<OrgsorgidprojectsprojectidbuildtargetsBuilds> response = GetShareMetadataWithHttpInfo(shareid, include);
             return response.Data;
        }

        /// <summary>
        /// Get details on shared build including download link This is an endpoint accessible without an api key that provides information about a\nspecific build including download links.\nA shareid is generated by POSTing to a &lt;a href=\&quot;#!/builds/createShare\&quot;&gt;build&#39;s share endpoint&lt;/a&gt;.
        /// </summary>
        /// <param name="shareid"></param> 
        /// <param name="include">Extra fields to include in the response</param> 
        /// <returns>ApiResponse of OrgsorgidprojectsprojectidbuildtargetsBuilds</returns>
        public ApiResponse< OrgsorgidprojectsprojectidbuildtargetsBuilds > GetShareMetadataWithHttpInfo (string shareid, string include = null)
        {
            
            // verify the required parameter 'shareid' is set
            if (shareid == null)
                throw new ApiException(400, "Missing required parameter 'shareid' when calling SharesApi->GetShareMetadata");
            
    
            var path_ = "/shares/{shareid}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json", "text/plain", "text/html"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (shareid != null) pathParams.Add("shareid", Configuration.ApiClient.ParameterToString(shareid)); // path parameter
            
            if (include != null) queryParams.Add("include", Configuration.ApiClient.ParameterToString(include)); // query parameter
            
            
            
            

            // authentication (apikey) required
            
            // http basic authentication required
            if (!String.IsNullOrEmpty(Configuration.Username) || !String.IsNullOrEmpty(Configuration.Password))
            {
                headerParams["Authorization"] = "Basic " + Base64Encode(Configuration.Username + ":" + Configuration.Password);
            }
            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling GetShareMetadata: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetShareMetadata: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<OrgsorgidprojectsprojectidbuildtargetsBuilds>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (OrgsorgidprojectsprojectidbuildtargetsBuilds) Configuration.ApiClient.Deserialize(response, typeof(OrgsorgidprojectsprojectidbuildtargetsBuilds)));
            
        }
    
        /// <summary>
        /// Get details on shared build including download link This is an endpoint accessible without an api key that provides information about a\nspecific build including download links.\nA shareid is generated by POSTing to a &lt;a href=\&quot;#!/builds/createShare\&quot;&gt;build&#39;s share endpoint&lt;/a&gt;.
        /// </summary>
        /// <param name="shareid"></param>
        /// <param name="include">Extra fields to include in the response</param>
        /// <returns>Task of OrgsorgidprojectsprojectidbuildtargetsBuilds</returns>
        public async System.Threading.Tasks.Task<OrgsorgidprojectsprojectidbuildtargetsBuilds> GetShareMetadataAsync (string shareid, string include = null)
        {
             ApiResponse<OrgsorgidprojectsprojectidbuildtargetsBuilds> response = await GetShareMetadataAsyncWithHttpInfo(shareid, include);
             return response.Data;

        }

        /// <summary>
        /// Get details on shared build including download link This is an endpoint accessible without an api key that provides information about a\nspecific build including download links.\nA shareid is generated by POSTing to a &lt;a href=\&quot;#!/builds/createShare\&quot;&gt;build&#39;s share endpoint&lt;/a&gt;.
        /// </summary>
        /// <param name="shareid"></param>
        /// <param name="include">Extra fields to include in the response</param>
        /// <returns>Task of ApiResponse (OrgsorgidprojectsprojectidbuildtargetsBuilds)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<OrgsorgidprojectsprojectidbuildtargetsBuilds>> GetShareMetadataAsyncWithHttpInfo (string shareid, string include = null)
        {
            // verify the required parameter 'shareid' is set
            if (shareid == null) throw new ApiException(400, "Missing required parameter 'shareid' when calling GetShareMetadata");
            
    
            var path_ = "/shares/{shareid}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json", "text/plain", "text/html"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (shareid != null) pathParams.Add("shareid", Configuration.ApiClient.ParameterToString(shareid)); // path parameter
            
            if (include != null) queryParams.Add("include", Configuration.ApiClient.ParameterToString(include)); // query parameter
            
            
            
            

            
            // authentication (apikey) required
            
            // http basic authentication required
            if (!String.IsNullOrEmpty(Configuration.Username) || !String.IsNullOrEmpty(Configuration.Password))
            {
                headerParams["Authorization"] = "Basic " + Base64Encode(Configuration.Username + ":" + Configuration.Password);
            }
            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling GetShareMetadata: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetShareMetadata: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<OrgsorgidprojectsprojectidbuildtargetsBuilds>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (OrgsorgidprojectsprojectidbuildtargetsBuilds) Configuration.ApiClient.Deserialize(response, typeof(OrgsorgidprojectsprojectidbuildtargetsBuilds)));
            
        }
        
    }
    
}
