using Amazon.CDK;
using AWS.Jsii.Runtime.Deputy;

namespace Amazon.CDK.AWS.EC2.cloudformation
{
    /// <remarks>link: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-flowlog.html </remarks>
    [JsiiInterface(typeof(IFlowLogResourceProps), "@aws-cdk/aws-ec2.cloudformation.FlowLogResourceProps")]
    public interface IFlowLogResourceProps
    {
        /// <summary>``AWS::EC2::FlowLog.DeliverLogsPermissionArn``</summary>
        /// <remarks>link: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-flowlog.html#cfn-ec2-flowlog-deliverlogspermissionarn </remarks>
        [JsiiProperty("deliverLogsPermissionArn", "{\"union\":{\"types\":[{\"primitive\":\"string\"},{\"fqn\":\"@aws-cdk/cdk.Token\"}]}}")]
        object DeliverLogsPermissionArn
        {
            get;
            set;
        }

        /// <summary>``AWS::EC2::FlowLog.LogGroupName``</summary>
        /// <remarks>link: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-flowlog.html#cfn-ec2-flowlog-loggroupname </remarks>
        [JsiiProperty("logGroupName", "{\"union\":{\"types\":[{\"primitive\":\"string\"},{\"fqn\":\"@aws-cdk/cdk.Token\"}]}}")]
        object LogGroupName
        {
            get;
            set;
        }

        /// <summary>``AWS::EC2::FlowLog.ResourceId``</summary>
        /// <remarks>link: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-flowlog.html#cfn-ec2-flowlog-resourceid </remarks>
        [JsiiProperty("resourceId", "{\"union\":{\"types\":[{\"primitive\":\"string\"},{\"fqn\":\"@aws-cdk/cdk.Token\"}]}}")]
        object ResourceId
        {
            get;
            set;
        }

        /// <summary>``AWS::EC2::FlowLog.ResourceType``</summary>
        /// <remarks>link: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-flowlog.html#cfn-ec2-flowlog-resourcetype </remarks>
        [JsiiProperty("resourceType", "{\"union\":{\"types\":[{\"primitive\":\"string\"},{\"fqn\":\"@aws-cdk/cdk.Token\"}]}}")]
        object ResourceType
        {
            get;
            set;
        }

        /// <summary>``AWS::EC2::FlowLog.TrafficType``</summary>
        /// <remarks>link: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-flowlog.html#cfn-ec2-flowlog-traffictype </remarks>
        [JsiiProperty("trafficType", "{\"union\":{\"types\":[{\"primitive\":\"string\"},{\"fqn\":\"@aws-cdk/cdk.Token\"}]}}")]
        object TrafficType
        {
            get;
            set;
        }
    }
}