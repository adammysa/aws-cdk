using Amazon.CDK;
using AWS.Jsii.Runtime.Deputy;

namespace Amazon.CDK.AWS.EC2.cloudformation
{
    /// <remarks>link: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-egressonlyinternetgateway.html </remarks>
    public class EgressOnlyInternetGatewayResourceProps : DeputyBase, IEgressOnlyInternetGatewayResourceProps
    {
        /// <summary>``AWS::EC2::EgressOnlyInternetGateway.VpcId``</summary>
        /// <remarks>link: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-egressonlyinternetgateway.html#cfn-ec2-egressonlyinternetgateway-vpcid </remarks>
        [JsiiProperty("vpcId", "{\"union\":{\"types\":[{\"primitive\":\"string\"},{\"fqn\":\"@aws-cdk/cdk.Token\"}]}}", true)]
        public object VpcId
        {
            get;
            set;
        }
    }
}