using Amazon.CDK;
using AWS.Jsii.Runtime.Deputy;

namespace Amazon.CDK.AWS.CodePipeline.cloudformation.PipelineResource
{
    /// <remarks>link: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codepipeline-pipeline-stages.html </remarks>
    [JsiiInterface(typeof(IStageDeclarationProperty), "@aws-cdk/aws-codepipeline.cloudformation.PipelineResource.StageDeclarationProperty")]
    public interface IStageDeclarationProperty
    {
        /// <summary>``PipelineResource.StageDeclarationProperty.Actions``</summary>
        /// <remarks>link: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codepipeline-pipeline-stages.html#cfn-codepipeline-pipeline-stages-actions </remarks>
        [JsiiProperty("actions", "{\"union\":{\"types\":[{\"fqn\":\"@aws-cdk/cdk.Token\"},{\"collection\":{\"kind\":\"array\",\"elementtype\":{\"union\":{\"types\":[{\"fqn\":\"@aws-cdk/aws-codepipeline.cloudformation.PipelineResource.ActionDeclarationProperty\"},{\"fqn\":\"@aws-cdk/cdk.Token\"}]}}}}]}}")]
        object Actions
        {
            get;
            set;
        }

        /// <summary>``PipelineResource.StageDeclarationProperty.Blockers``</summary>
        /// <remarks>link: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codepipeline-pipeline-stages.html#cfn-codepipeline-pipeline-stages-blockers </remarks>
        [JsiiProperty("blockers", "{\"union\":{\"types\":[{\"fqn\":\"@aws-cdk/cdk.Token\"},{\"collection\":{\"kind\":\"array\",\"elementtype\":{\"union\":{\"types\":[{\"fqn\":\"@aws-cdk/cdk.Token\"},{\"fqn\":\"@aws-cdk/aws-codepipeline.cloudformation.PipelineResource.BlockerDeclarationProperty\"}]}}}}]},\"optional\":true}")]
        object Blockers
        {
            get;
            set;
        }

        /// <summary>``PipelineResource.StageDeclarationProperty.Name``</summary>
        /// <remarks>link: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codepipeline-pipeline-stages.html#cfn-codepipeline-pipeline-stages-name </remarks>
        [JsiiProperty("name", "{\"union\":{\"types\":[{\"primitive\":\"string\"},{\"fqn\":\"@aws-cdk/cdk.Token\"}]}}")]
        object Name
        {
            get;
            set;
        }
    }
}