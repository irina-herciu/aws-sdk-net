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
 * Do not modify this file. This file is generated from the mediaconvert-2017-08-29.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.MediaConvert.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.MediaConvert.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Input Marshaller
    /// </summary>
    public class InputMarshaller : IRequestMarshaller<Input, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(Input requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAdvancedInputFilter())
            {
                context.Writer.WritePropertyName("advancedInputFilter");
                context.Writer.Write(requestObject.AdvancedInputFilter);
            }

            if(requestObject.IsSetAdvancedInputFilterSettings())
            {
                context.Writer.WritePropertyName("advancedInputFilterSettings");
                context.Writer.WriteObjectStart();

                var marshaller = AdvancedInputFilterSettingsMarshaller.Instance;
                marshaller.Marshall(requestObject.AdvancedInputFilterSettings, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetAudioSelectorGroups())
            {
                context.Writer.WritePropertyName("audioSelectorGroups");
                context.Writer.WriteObjectStart();
                foreach (var requestObjectAudioSelectorGroupsKvp in requestObject.AudioSelectorGroups)
                {
                    context.Writer.WritePropertyName(requestObjectAudioSelectorGroupsKvp.Key);
                    var requestObjectAudioSelectorGroupsValue = requestObjectAudioSelectorGroupsKvp.Value;

                    context.Writer.WriteObjectStart();

                    var marshaller = AudioSelectorGroupMarshaller.Instance;
                    marshaller.Marshall(requestObjectAudioSelectorGroupsValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetAudioSelectors())
            {
                context.Writer.WritePropertyName("audioSelectors");
                context.Writer.WriteObjectStart();
                foreach (var requestObjectAudioSelectorsKvp in requestObject.AudioSelectors)
                {
                    context.Writer.WritePropertyName(requestObjectAudioSelectorsKvp.Key);
                    var requestObjectAudioSelectorsValue = requestObjectAudioSelectorsKvp.Value;

                    context.Writer.WriteObjectStart();

                    var marshaller = AudioSelectorMarshaller.Instance;
                    marshaller.Marshall(requestObjectAudioSelectorsValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetCaptionSelectors())
            {
                context.Writer.WritePropertyName("captionSelectors");
                context.Writer.WriteObjectStart();
                foreach (var requestObjectCaptionSelectorsKvp in requestObject.CaptionSelectors)
                {
                    context.Writer.WritePropertyName(requestObjectCaptionSelectorsKvp.Key);
                    var requestObjectCaptionSelectorsValue = requestObjectCaptionSelectorsKvp.Value;

                    context.Writer.WriteObjectStart();

                    var marshaller = CaptionSelectorMarshaller.Instance;
                    marshaller.Marshall(requestObjectCaptionSelectorsValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetCrop())
            {
                context.Writer.WritePropertyName("crop");
                context.Writer.WriteObjectStart();

                var marshaller = RectangleMarshaller.Instance;
                marshaller.Marshall(requestObject.Crop, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetDeblockFilter())
            {
                context.Writer.WritePropertyName("deblockFilter");
                context.Writer.Write(requestObject.DeblockFilter);
            }

            if(requestObject.IsSetDecryptionSettings())
            {
                context.Writer.WritePropertyName("decryptionSettings");
                context.Writer.WriteObjectStart();

                var marshaller = InputDecryptionSettingsMarshaller.Instance;
                marshaller.Marshall(requestObject.DecryptionSettings, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetDenoiseFilter())
            {
                context.Writer.WritePropertyName("denoiseFilter");
                context.Writer.Write(requestObject.DenoiseFilter);
            }

            if(requestObject.IsSetDolbyVisionMetadataXml())
            {
                context.Writer.WritePropertyName("dolbyVisionMetadataXml");
                context.Writer.Write(requestObject.DolbyVisionMetadataXml);
            }

            if(requestObject.IsSetDynamicAudioSelectors())
            {
                context.Writer.WritePropertyName("dynamicAudioSelectors");
                context.Writer.WriteObjectStart();
                foreach (var requestObjectDynamicAudioSelectorsKvp in requestObject.DynamicAudioSelectors)
                {
                    context.Writer.WritePropertyName(requestObjectDynamicAudioSelectorsKvp.Key);
                    var requestObjectDynamicAudioSelectorsValue = requestObjectDynamicAudioSelectorsKvp.Value;

                    context.Writer.WriteObjectStart();

                    var marshaller = DynamicAudioSelectorMarshaller.Instance;
                    marshaller.Marshall(requestObjectDynamicAudioSelectorsValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetFileInput())
            {
                context.Writer.WritePropertyName("fileInput");
                context.Writer.Write(requestObject.FileInput);
            }

            if(requestObject.IsSetFilterEnable())
            {
                context.Writer.WritePropertyName("filterEnable");
                context.Writer.Write(requestObject.FilterEnable);
            }

            if(requestObject.IsSetFilterStrength())
            {
                context.Writer.WritePropertyName("filterStrength");
                context.Writer.Write(requestObject.FilterStrength);
            }

            if(requestObject.IsSetImageInserter())
            {
                context.Writer.WritePropertyName("imageInserter");
                context.Writer.WriteObjectStart();

                var marshaller = ImageInserterMarshaller.Instance;
                marshaller.Marshall(requestObject.ImageInserter, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetInputClippings())
            {
                context.Writer.WritePropertyName("inputClippings");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectInputClippingsListValue in requestObject.InputClippings)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = InputClippingMarshaller.Instance;
                    marshaller.Marshall(requestObjectInputClippingsListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetInputScanType())
            {
                context.Writer.WritePropertyName("inputScanType");
                context.Writer.Write(requestObject.InputScanType);
            }

            if(requestObject.IsSetPosition())
            {
                context.Writer.WritePropertyName("position");
                context.Writer.WriteObjectStart();

                var marshaller = RectangleMarshaller.Instance;
                marshaller.Marshall(requestObject.Position, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetProgramNumber())
            {
                context.Writer.WritePropertyName("programNumber");
                context.Writer.Write(requestObject.ProgramNumber);
            }

            if(requestObject.IsSetPsiControl())
            {
                context.Writer.WritePropertyName("psiControl");
                context.Writer.Write(requestObject.PsiControl);
            }

            if(requestObject.IsSetSupplementalImps())
            {
                context.Writer.WritePropertyName("supplementalImps");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectSupplementalImpsListValue in requestObject.SupplementalImps)
                {
                        context.Writer.Write(requestObjectSupplementalImpsListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetTimecodeSource())
            {
                context.Writer.WritePropertyName("timecodeSource");
                context.Writer.Write(requestObject.TimecodeSource);
            }

            if(requestObject.IsSetTimecodeStart())
            {
                context.Writer.WritePropertyName("timecodeStart");
                context.Writer.Write(requestObject.TimecodeStart);
            }

            if(requestObject.IsSetVideoGenerator())
            {
                context.Writer.WritePropertyName("videoGenerator");
                context.Writer.WriteObjectStart();

                var marshaller = InputVideoGeneratorMarshaller.Instance;
                marshaller.Marshall(requestObject.VideoGenerator, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetVideoOverlays())
            {
                context.Writer.WritePropertyName("videoOverlays");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectVideoOverlaysListValue in requestObject.VideoOverlays)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = VideoOverlayMarshaller.Instance;
                    marshaller.Marshall(requestObjectVideoOverlaysListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetVideoSelector())
            {
                context.Writer.WritePropertyName("videoSelector");
                context.Writer.WriteObjectStart();

                var marshaller = VideoSelectorMarshaller.Instance;
                marshaller.Marshall(requestObject.VideoSelector, context);

                context.Writer.WriteObjectEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static InputMarshaller Instance = new InputMarshaller();

    }
}