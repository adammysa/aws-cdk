using Amazon.CDK;
using AWS.Jsii.Runtime.Deputy;

namespace Amazon.CDK.AWS.SES.cloudformation.ReceiptRuleResource
{
    /// <remarks>link: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-receiptrule-stopaction.html </remarks>
    [JsiiInterface(typeof(IStopActionProperty), "@aws-cdk/aws-ses.cloudformation.ReceiptRuleResource.StopActionProperty")]
    public interface IStopActionProperty
    {
        /// <summary>``ReceiptRuleResource.StopActionProperty.Scope``</summary>
        /// <remarks>link: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-receiptrule-stopaction.html#cfn-ses-receiptrule-stopaction-scope </remarks>
        [JsiiProperty("scope", "{\"union\":{\"types\":[{\"primitive\":\"string\"},{\"fqn\":\"@aws-cdk/cdk.Token\"}]}}")]
        object Scope
        {
            get;
            set;
        }

        /// <summary>``ReceiptRuleResource.StopActionProperty.TopicArn``</summary>
        /// <remarks>link: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-receiptrule-stopaction.html#cfn-ses-receiptrule-stopaction-topicarn </remarks>
        [JsiiProperty("topicArn", "{\"union\":{\"types\":[{\"primitive\":\"string\"},{\"fqn\":\"@aws-cdk/cdk.Token\"}]},\"optional\":true}")]
        object TopicArn
        {
            get;
            set;
        }
    }
}