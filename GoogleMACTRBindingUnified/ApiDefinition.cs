using System;
using System.Drawing;

using ObjCRuntime;
using Foundation;
using UIKit;

namespace GoogleMACTRBindingUnified
{
	// @interface ACTReporter : NSObject
	[BaseType (typeof (NSObject))]
	interface ACTReporter {

		// +(NSString *)SDKVersion;
		[Static, Export ("SDKVersion")]
		string SDKVersion ();

		// -(BOOL)report;
		[Export ("report")]
		bool Report ();
	}

	// @interface ACTConversionReporter : ACTReporter
	[BaseType (typeof (ACTReporter))]
	interface ACTConversionReporter {

		// -(instancetype)initWithConversionID:(NSString *)conversionID label:(NSString *)label value:(NSString *)value isRepeatable:(BOOL)isRepeatable;
		[Export ("initWithConversionID:label:value:isRepeatable:")]
		IntPtr Constructor (string conversionID, string label, string value, bool isRepeatable);

		// -(instancetype)initWithProductID:(NSString *)productID value:(NSString *)value isRepeatable:(BOOL)isRepeatable;
		[Export ("initWithProductID:value:isRepeatable:")]
		IntPtr Constructor (string productID, string value, bool isRepeatable);

		// @property (copy, nonatomic) NSString * value;
		[Export ("value")]
		string Value { get; set; }

		// +(void)reportWithConversionID:(NSString *)conversionID label:(NSString *)label value:(NSString *)value isRepeatable:(BOOL)isRepeatable;
		[Static, Export ("reportWithConversionID:label:value:isRepeatable:")]
		void ReportWithConversionID (string conversionID, string label, string value, bool isRepeatable);

		// +(void)reportWithProductID:(NSString *)productID value:(NSString *)value isRepeatable:(BOOL)isRepeatable;
		[Static, Export ("reportWithProductID:value:isRepeatable:")]
		void ReportWithProductID (string productID, string value, bool isRepeatable);

		// +(BOOL)registerReferrer:(NSURL *)clickURL;
		[Static, Export ("registerReferrer:")]
		bool RegisterReferrer (NSUrl clickURL);
	}

	// @interface ACTRemarketingReporter : ACTReporter
	[BaseType (typeof (ACTReporter))]
	interface ACTRemarketingReporter {

		// -(instancetype)initWithConversionID:(NSString *)conversionID customParameters:(NSDictionary *)customParameters;
		[Export ("initWithConversionID:customParameters:")]
		IntPtr Constructor (string conversionID, NSDictionary customParameters);

		// +(void)reportWithConversionID:(NSString *)conversionID customParameters:(NSDictionary *)customParameters;
		[Static, Export ("reportWithConversionID:customParameters:")]
		void ReportWithConversionID (string conversionID, NSDictionary customParameters);
	}

	// @interface ACTAutomatedUsageTracker : NSObject
	[BaseType (typeof (NSObject))]
	interface ACTAutomatedUsageTracker {

		// +(void)enableAutomatedUsageReportingWithConversionID:(NSString *)conversionID;
		[Static, Export ("enableAutomatedUsageReportingWithConversionID:")]
		void EnableAutomatedUsageReportingWithConversionID (string conversionID);

		// +(void)disableAutomatedUsageReportingWithConversionID:(NSString *)conversionID;
		[Static, Export ("disableAutomatedUsageReportingWithConversionID:")]
		void DisableAutomatedUsageReportingWithConversionID (string conversionID);
	}

}

