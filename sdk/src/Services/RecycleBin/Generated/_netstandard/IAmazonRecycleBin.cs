/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the rbin-2021-06-15.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.RecycleBin.Model;

#pragma warning disable CS1570
namespace Amazon.RecycleBin
{
    /// <summary>
    /// <para>Interface for accessing RecycleBin</para>
    ///
    /// This is the <i>Recycle Bin API Reference</i>. This documentation provides descriptions
    /// and syntax for each of the actions and data types in Recycle Bin.
    /// 
    ///  
    /// <para>
    /// Recycle Bin is a resource recovery feature that enables you to restore accidentally
    /// deleted snapshots and EBS-backed AMIs. When using Recycle Bin, if your resources are
    /// deleted, they are retained in the Recycle Bin for a time period that you specify.
    /// </para>
    ///  
    /// <para>
    /// You can restore a resource from the Recycle Bin at any time before its retention period
    /// expires. After you restore a resource from the Recycle Bin, the resource is removed
    /// from the Recycle Bin, and you can then use it in the same way you use any other resource
    /// of that type in your account. If the retention period expires and the resource is
    /// not restored, the resource is permanently deleted from the Recycle Bin and is no longer
    /// available for recovery. For more information about Recycle Bin, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/recycle-bin.html">
    /// Recycle Bin</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
    /// </para>
    /// </summary>
    public partial interface IAmazonRecycleBin : IAmazonService, IDisposable
    {
#if AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        IRecycleBinPaginatorFactory Paginators { get; }
#endif
                
        #region  CreateRule



        /// <summary>
        /// Creates a Recycle Bin retention rule. You can create two types of retention rules:
        /// 
        ///  <ul> <li> 
        /// <para>
        ///  <b>Tag-level retention rules</b> - These retention rules use resource tags to identify
        /// the resources to protect. For each retention rule, you specify one or more tag key
        /// and value pairs. Resources (of the specified type) that have at least one of these
        /// tag key and value pairs are automatically retained in the Recycle Bin upon deletion.
        /// Use this type of retention rule to protect specific resources in your account based
        /// on their tags.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Region-level retention rules</b> - These retention rules, by default, apply to
        /// all of the resources (of the specified type) in the Region, even if the resources
        /// are not tagged. However, you can specify exclusion tags to exclude resources that
        /// have specific tags. Use this type of retention rule to protect all resources of a
        /// specific type in a Region.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/ebs/latest/userguide/recycle-bin.html">
        /// Create Recycle Bin retention rules</a> in the <i>Amazon EBS User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateRule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateRule service method, as returned by RecycleBin.</returns>
        /// <exception cref="Amazon.RecycleBin.Model.InternalServerException">
        /// The service could not respond to the request due to an internal problem.
        /// </exception>
        /// <exception cref="Amazon.RecycleBin.Model.ServiceQuotaExceededException">
        /// The request would cause a service quota for the number of tags per resource to be
        /// exceeded.
        /// </exception>
        /// <exception cref="Amazon.RecycleBin.Model.ValidationException">
        /// One or more of the parameters in the request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rbin-2021-06-15/CreateRule">REST API Reference for CreateRule Operation</seealso>
        Task<CreateRuleResponse> CreateRuleAsync(CreateRuleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteRule



        /// <summary>
        /// Deletes a Recycle Bin retention rule. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/recycle-bin-working-with-rules.html#recycle-bin-delete-rule">
        /// Delete Recycle Bin retention rules</a> in the <i>Amazon Elastic Compute Cloud User
        /// Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteRule service method, as returned by RecycleBin.</returns>
        /// <exception cref="Amazon.RecycleBin.Model.ConflictException">
        /// The specified retention rule lock request can't be completed.
        /// </exception>
        /// <exception cref="Amazon.RecycleBin.Model.InternalServerException">
        /// The service could not respond to the request due to an internal problem.
        /// </exception>
        /// <exception cref="Amazon.RecycleBin.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.RecycleBin.Model.ValidationException">
        /// One or more of the parameters in the request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rbin-2021-06-15/DeleteRule">REST API Reference for DeleteRule Operation</seealso>
        Task<DeleteRuleResponse> DeleteRuleAsync(DeleteRuleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetRule



        /// <summary>
        /// Gets information about a Recycle Bin retention rule.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetRule service method, as returned by RecycleBin.</returns>
        /// <exception cref="Amazon.RecycleBin.Model.InternalServerException">
        /// The service could not respond to the request due to an internal problem.
        /// </exception>
        /// <exception cref="Amazon.RecycleBin.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.RecycleBin.Model.ValidationException">
        /// One or more of the parameters in the request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rbin-2021-06-15/GetRule">REST API Reference for GetRule Operation</seealso>
        Task<GetRuleResponse> GetRuleAsync(GetRuleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListRules



        /// <summary>
        /// Lists the Recycle Bin retention rules in the Region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRules service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListRules service method, as returned by RecycleBin.</returns>
        /// <exception cref="Amazon.RecycleBin.Model.InternalServerException">
        /// The service could not respond to the request due to an internal problem.
        /// </exception>
        /// <exception cref="Amazon.RecycleBin.Model.ValidationException">
        /// One or more of the parameters in the request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rbin-2021-06-15/ListRules">REST API Reference for ListRules Operation</seealso>
        Task<ListRulesResponse> ListRulesAsync(ListRulesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListTagsForResource



        /// <summary>
        /// Lists the tags assigned to a retention rule.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by RecycleBin.</returns>
        /// <exception cref="Amazon.RecycleBin.Model.InternalServerException">
        /// The service could not respond to the request due to an internal problem.
        /// </exception>
        /// <exception cref="Amazon.RecycleBin.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.RecycleBin.Model.ValidationException">
        /// One or more of the parameters in the request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rbin-2021-06-15/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  LockRule



        /// <summary>
        /// Locks a Region-level retention rule. A locked retention rule can't be modified or
        /// deleted.
        /// 
        ///  <note> 
        /// <para>
        /// You can't lock tag-level retention rules, or Region-level retention rules that have
        /// exclusion tags.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the LockRule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the LockRule service method, as returned by RecycleBin.</returns>
        /// <exception cref="Amazon.RecycleBin.Model.ConflictException">
        /// The specified retention rule lock request can't be completed.
        /// </exception>
        /// <exception cref="Amazon.RecycleBin.Model.InternalServerException">
        /// The service could not respond to the request due to an internal problem.
        /// </exception>
        /// <exception cref="Amazon.RecycleBin.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.RecycleBin.Model.ValidationException">
        /// One or more of the parameters in the request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rbin-2021-06-15/LockRule">REST API Reference for LockRule Operation</seealso>
        Task<LockRuleResponse> LockRuleAsync(LockRuleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  TagResource



        /// <summary>
        /// Assigns tags to the specified retention rule.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by RecycleBin.</returns>
        /// <exception cref="Amazon.RecycleBin.Model.InternalServerException">
        /// The service could not respond to the request due to an internal problem.
        /// </exception>
        /// <exception cref="Amazon.RecycleBin.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.RecycleBin.Model.ServiceQuotaExceededException">
        /// The request would cause a service quota for the number of tags per resource to be
        /// exceeded.
        /// </exception>
        /// <exception cref="Amazon.RecycleBin.Model.ValidationException">
        /// One or more of the parameters in the request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rbin-2021-06-15/TagResource">REST API Reference for TagResource Operation</seealso>
        Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UnlockRule



        /// <summary>
        /// Unlocks a retention rule. After a retention rule is unlocked, it can be modified or
        /// deleted only after the unlock delay period expires.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UnlockRule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UnlockRule service method, as returned by RecycleBin.</returns>
        /// <exception cref="Amazon.RecycleBin.Model.ConflictException">
        /// The specified retention rule lock request can't be completed.
        /// </exception>
        /// <exception cref="Amazon.RecycleBin.Model.InternalServerException">
        /// The service could not respond to the request due to an internal problem.
        /// </exception>
        /// <exception cref="Amazon.RecycleBin.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.RecycleBin.Model.ValidationException">
        /// One or more of the parameters in the request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rbin-2021-06-15/UnlockRule">REST API Reference for UnlockRule Operation</seealso>
        Task<UnlockRuleResponse> UnlockRuleAsync(UnlockRuleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UntagResource



        /// <summary>
        /// Unassigns a tag from a retention rule.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by RecycleBin.</returns>
        /// <exception cref="Amazon.RecycleBin.Model.InternalServerException">
        /// The service could not respond to the request due to an internal problem.
        /// </exception>
        /// <exception cref="Amazon.RecycleBin.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.RecycleBin.Model.ValidationException">
        /// One or more of the parameters in the request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rbin-2021-06-15/UntagResource">REST API Reference for UntagResource Operation</seealso>
        Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateRule



        /// <summary>
        /// Updates an existing Recycle Bin retention rule. You can update a retention rule's
        /// description, resource tags, and retention period at any time after creation. You can't
        /// update a retention rule's resource type after creation. For more information, see
        /// <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/recycle-bin-working-with-rules.html#recycle-bin-update-rule">
        /// Update Recycle Bin retention rules</a> in the <i>Amazon Elastic Compute Cloud User
        /// Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateRule service method, as returned by RecycleBin.</returns>
        /// <exception cref="Amazon.RecycleBin.Model.ConflictException">
        /// The specified retention rule lock request can't be completed.
        /// </exception>
        /// <exception cref="Amazon.RecycleBin.Model.InternalServerException">
        /// The service could not respond to the request due to an internal problem.
        /// </exception>
        /// <exception cref="Amazon.RecycleBin.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.RecycleBin.Model.ServiceQuotaExceededException">
        /// The request would cause a service quota for the number of tags per resource to be
        /// exceeded.
        /// </exception>
        /// <exception cref="Amazon.RecycleBin.Model.ValidationException">
        /// One or more of the parameters in the request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rbin-2021-06-15/UpdateRule">REST API Reference for UpdateRule Operation</seealso>
        Task<UpdateRuleResponse> UpdateRuleAsync(UpdateRuleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region DetermineServiceOperationEndpoint

        /// <summary>
        /// Returns the endpoint that will be used for a particular request.
        /// </summary>
        /// <param name="request">Request for the desired service operation.</param>
        /// <returns>The resolved endpoint for the given request.</returns>
        Amazon.Runtime.Endpoints.Endpoint DetermineServiceOperationEndpoint(AmazonWebServiceRequest request);
        
        #endregion

        #region Static factory interface methods
#if NET8_0_OR_GREATER
// Warning CA1033 is issued when the child types can not call the method defined in parent types.
// In this use case the intended caller is only meant to be the interface as a factory
// method to create the child types. Given the SDK use case the warning can be ignored.
#pragma warning disable CA1033
        /// <inheritdoc/>
        [System.Diagnostics.CodeAnalysis.DynamicDependency(System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypes.PublicProperties, typeof(AmazonRecycleBinConfig))]
        static ClientConfig IAmazonService.CreateDefaultClientConfig() => new AmazonRecycleBinConfig();

        /// <inheritdoc/>
        [System.Diagnostics.CodeAnalysis.UnconditionalSuppressMessage("AssemblyLoadTrimming", "IL2026:RequiresUnreferencedCode",
    Justification = "This suppression is here to ignore the warnings caused by CognitoSync. See justification in IAmazonService.")]
        static IAmazonService IAmazonService.CreateDefaultServiceClient(AWSCredentials awsCredentials, ClientConfig clientConfig)
        {
            var serviceClientConfig = clientConfig as AmazonRecycleBinConfig;
            if (serviceClientConfig == null)
            {
                throw new AmazonClientException("ClientConfig is not of type AmazonRecycleBinConfig to create AmazonRecycleBinClient");
            }

            return awsCredentials == null ? 
                    new AmazonRecycleBinClient(serviceClientConfig) :
                    new AmazonRecycleBinClient(awsCredentials, serviceClientConfig);
        }
#pragma warning restore CA1033
#endif
        #endregion
    }
}