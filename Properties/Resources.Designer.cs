﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Vulnerator.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Vulnerator.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to INSERT INTO Software (Software_ID, Discovered_Software_Name, Displayed_Software_Name, Is_OS_Or_Firmware) VALUES (NULL, @Discovered_Software_Name, @Displayed_Software_Name, @Is_OS_Or_Firmware);.
        /// </summary>
        internal static string InsertAcasDiscoveredSoftware {
            get {
                return ResourceManager.GetString("InsertAcasDiscoveredSoftware", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to .
        /// </summary>
        internal static string InsertAcasUniqueFinding {
            get {
                return ResourceManager.GetString("InsertAcasUniqueFinding", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to INSERT INTO UniqueFindings (Unique_Finding_ID, Comments, Finding_Details, First_Discovered, Last_Observed, Approval_Status, Delta_Analysis_Required, Finding_Type_ID, Finding_Source_File_ID, Status, Vulnerability_ID, Hardware_ID, Severity_Override, Severity_Override_Justification, Technology_Area, Web_DB_Site, Web_DB_Instance, Classification, Tool_Generated_Output) VALUES (NULL, @Comments, @Finding_Details, @First_Discovered, @Last_Observed, @Approval_Status, @Delta_Analysis_Required, @Finding_Type_ID, @Find [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string InsertCklUniqueFinding {
            get {
                return ResourceManager.GetString("InsertCklUniqueFinding", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to INSERT INTO Groups VALUES (NULL, @Group_Name, &apos;False&apos;, NULL, NULL);.
        /// </summary>
        internal static string InsertGroup {
            get {
                return ResourceManager.GetString("InsertGroup", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to INSERT INTO Hardware VALUES (NULL,@Host_Name,@FQDN,@NetBios,@Is_Virtual_Server,@NIAP_Level,@Manufacturer,@ModelNumber,@Is_IA_Enabled,@SerialNumber,@Role,NULL);.
        /// </summary>
        internal static string InsertHardware {
            get {
                return ResourceManager.GetString("InsertHardware", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to INSERT INTO IP_Addresses VALUES (NULL, @IP_Address);.
        /// </summary>
        internal static string InsertIpAddress {
            get {
                return ResourceManager.GetString("InsertIpAddress", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to INSERT INTO MAC_Addresses VALUES (NULL, @MAC_Address);.
        /// </summary>
        internal static string InsertMacAddress {
            get {
                return ResourceManager.GetString("InsertMacAddress", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to INSERT INTO PPS VALUES (NULL, @Port, @Protocol);.
        /// </summary>
        internal static string InsertPort {
            get {
                return ResourceManager.GetString("InsertPort", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to INSERT INTO UniqueFindings () VALUES ();.
        /// </summary>
        internal static string InsertUniqueFinding {
            get {
                return ResourceManager.GetString("InsertUniqueFinding", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to INSERT INTO UniqueFindingsSourceFiles VALUES (NULL, @Finding_Source_File_Name);.
        /// </summary>
        internal static string InsertUniqueFindingSource {
            get {
                return ResourceManager.GetString("InsertUniqueFindingSource", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to INSERT INTO Vulnerabilities () VALUES ();.
        /// </summary>
        internal static string InsertVulnerability {
            get {
                return ResourceManager.GetString("InsertVulnerability", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to INSERT INTO VulnerabilityReferences VALUES (NULL, @Reference, @Reference_Type);.
        /// </summary>
        internal static string InsertVulnerabilityReference {
            get {
                return ResourceManager.GetString("InsertVulnerabilityReference", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to INSERT INTO VulnerabilitySources () VALUES ();.
        /// </summary>
        internal static string InsertVulnerabilitySource {
            get {
                return ResourceManager.GetString("InsertVulnerabilitySource", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to INSERT INTO SoftwareHardware (Software_ID, Hardware_ID) VALUES (@Software_ID, @Hardware_ID);.
        /// </summary>
        internal static string MapHardwareToSoftware {
            get {
                return ResourceManager.GetString("MapHardwareToSoftware", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to INSERT INTO HardwareIpAddresses VALUES (@Hardware_ID, @IP_Address_ID);.
        /// </summary>
        internal static string MapIpToHardware {
            get {
                return ResourceManager.GetString("MapIpToHardware", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to INSERT INTO HardwareMacAddresses VALUES (@Hardware_ID, @MAC_Address_ID);.
        /// </summary>
        internal static string MapMacToHardware {
            get {
                return ResourceManager.GetString("MapMacToHardware", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to INSERT INTO Hardware_PPS (Hardware_ID, PPS_ID) VALUES (@Hardware_ID, @PPS_ID);.
        /// </summary>
        internal static string MapPortToHardware {
            get {
                return ResourceManager.GetString("MapPortToHardware", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to INSERT INTO Vulnerabilities_VulnerabilityReferences VALUES (@Vulnerability_ID, @Reference_ID);.
        /// </summary>
        internal static string MapReferenceToVulnerability {
            get {
                return ResourceManager.GetString("MapReferenceToVulnerability", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to INSERT OR REPLACE INTO VulnerabilitesCCIs VALUES (@Vulnerability_ID, (SELECT CCI_ID FROM CCIs WHERE CCI = @CCI));.
        /// </summary>
        internal static string MapVulnerabilityToCci {
            get {
                return ResourceManager.GetString("MapVulnerabilityToCci", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to INSERT OR REPLACE INTO Vulnerabilities_IA_Controls VALUES (@Vulnerablity_ID, (SELECT IA_Control_ID FROM IA_Controls WHERE IA_Control_Number = @IA_Control));.
        /// </summary>
        internal static string MapVulnerabilityToIAControl {
            get {
                return ResourceManager.GetString("MapVulnerabilityToIAControl", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to INSERT INTO Vulnerabilities_VulnerabilitySources VALUES (@Vulnerability_ID, @Vulnerability_Source_ID);.
        /// </summary>
        internal static string MapVulnerabilityToSource {
            get {
                return ResourceManager.GetString("MapVulnerabilityToSource", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ^(([0-9]|[1-9][0-9]|1[0-9]{2}|2[0-4][0-9]|25[0-5])\.){3}([0-9]|[1-9][0-9]|1[0-9]{2}|2[0-4][0-9]|25[0-5])$.
        /// </summary>
        internal static string RegexIPv4 {
            get {
                return ResourceManager.GetString("RegexIPv4", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to (([0-9a-fA-F]{1,4}:){7,7}[0-9a-fA-F]{1,4}|([0-9a-fA-F]{1,4}:){1,7}:|([0-9a-fA-F]{1,4}:){1,6}:[0-9a-fA-F]{1,4}|([0-9a-fA-F]{1,4}:){1,5}(:[0-9a-fA-F]{1,4}){1,2}|([0-9a-fA-F]{1,4}:){1,4}(:[0-9a-fA-F]{1,4}){1,3}|([0-9a-fA-F]{1,4}:){1,3}(:[0-9a-fA-F]{1,4}){1,4}|([0-9a-fA-F]{1,4}:){1,2}(:[0-9a-fA-F]{1,4}){1,5}|[0-9a-fA-F]{1,4}:((:[0-9a-fA-F]{1,4}){1,6})|:((:[0-9a-fA-F]{1,4}){1,7}|:)|fe80:(:[0-9a-fA-F]{0,4}){0,4}%[0-9a-zA-Z]{1,}|::(ffff(:0{1,4}){0,1}:){0,1}((25[0-5]|(2[0-4]|1{0,1}[0-9]){0,1}[0-9])\.){3,3}(25[0-5]| [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string RegexIPv6 {
            get {
                return ResourceManager.GetString("RegexIPv6", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ^([0-9A-Fa-f]{2}[:-]){5}([0-9A-Fa-f]{2})$.
        /// </summary>
        internal static string RegexMAC {
            get {
                return ResourceManager.GetString("RegexMAC", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SELECT Vulnerability_Source_ID FROM VulnerabilitySources WHERE Source_Name = @Source_Name AND Source_Version = @Source_Version AND Source_Release = @Source_Release;.
        /// </summary>
        internal static string SelectAcasVulnerabilitySource {
            get {
                return ResourceManager.GetString("SelectAcasVulnerabilitySource", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SELECT Finding_Type_ID FROM FindingTypes WHERE Finding_Type = @Finding_Type;.
        /// </summary>
        internal static string SelectFindingTypeId {
            get {
                return ResourceManager.GetString("SelectFindingTypeId", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SELECT Group_ID FROM Groups WHERE Group_Name = @Group_Name;.
        /// </summary>
        internal static string SelectGroup {
            get {
                return ResourceManager.GetString("SelectGroup", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SELECT Hardware_ID FROM Hardware WHERE Host_Name = @Host_Name;.
        /// </summary>
        internal static string SelectHardware {
            get {
                return ResourceManager.GetString("SelectHardware", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SELECT IP_Address_ID FROM IP_Addresses WHERE IP_Address = @IP_Address;.
        /// </summary>
        internal static string SelectIpAddress {
            get {
                return ResourceManager.GetString("SelectIpAddress", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SELECT MAC_Address_ID FROM MAC_Addresses WHERE MAC_Address = @MAC_Address;.
        /// </summary>
        internal static string SelectMacAddress {
            get {
                return ResourceManager.GetString("SelectMacAddress", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SELECT PPS_ID FROM PPS WHERE Port = @Port AND Protocol = @Protocol;.
        /// </summary>
        internal static string SelectPort {
            get {
                return ResourceManager.GetString("SelectPort", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SELECT Software_ID FROM Software WHERE Discovered_Software_Name = @Discovered_Software_Name;.
        /// </summary>
        internal static string SelectSoftware {
            get {
                return ResourceManager.GetString("SelectSoftware", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SELECT Unique_Finding_ID FROM UniqueFindings WHERE Vulnerability_ID = @Vulnerability_ID AND Hardware_ID = @Hardware_ID;.
        /// </summary>
        internal static string SelectUniqueFinding {
            get {
                return ResourceManager.GetString("SelectUniqueFinding", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SELECT Finding_Source_File_ID FROM UniqueFindingsSourceFiles WHERE Finding_Source_File_Name = @Finding_Source_File_Name;.
        /// </summary>
        internal static string SelectUniqueFindingSourceFile {
            get {
                return ResourceManager.GetString("SelectUniqueFindingSourceFile", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SELECT Vulnerability_ID FROM Vulnerabilities WHERE Unique_Vulnerability_Identifier = @Unique_Vulnerability_Identifier;.
        /// </summary>
        internal static string SelectVulnerability {
            get {
                return ResourceManager.GetString("SelectVulnerability", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SELECT Reference_ID FROM VulnerabilityReferences WHERE Reference = @Reference AND Reference_Type = @Reference_Type;.
        /// </summary>
        internal static string SelectVulnerabilityReference {
            get {
                return ResourceManager.GetString("SelectVulnerabilityReference", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SELECT Vulnerability_Source_ID FROM VulnerabilitySources WHERE Source_Name = @Source_Name;.
        /// </summary>
        internal static string SelectVulnerabilitySource {
            get {
                return ResourceManager.GetString("SelectVulnerabilitySource", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to UPDATE UniqueFindings SET Tool_Generated_Output = @Tool_Generated_Output, Last_Observed = @Last_Observed, Status = @Status WHERE Unique_Finding_ID = @Unique_Finding_ID;.
        /// </summary>
        internal static string UpdateAcasUniqueFinding {
            get {
                return ResourceManager.GetString("UpdateAcasUniqueFinding", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to UPDATE UniqueFindings SET Finding_Details = @Finding_Details, Comments = @Comments, Severity_Override = @Severity_Override, Severity_Override_Justification = @Severity_Override_Justification, Last_Observed = @Last_Observed, Technology_Area = @Technology_Area, Web_DB_Site = @Web_DB_Site, Web_DB_Instance = @Web_DB_Instance, Finding_Source_File_ID = @Finding_Source_File_ID, Status = @Status, Approval_Status = @Approval_Status, Delta_Analysis_Required = @Delta_Analysis_Required, Tool_Generated_Output = @Tool_Ge [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string UpdateCklUniqueFinding {
            get {
                return ResourceManager.GetString("UpdateCklUniqueFinding", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to UPDATE UniqueFindings SET Delta_Analysis_Required = &apos;True&apos; WHERE Vulnerability_ID = @Vulnerability_ID;.
        /// </summary>
        internal static string UpdateDeltaAnalysisFlag {
            get {
                return ResourceManager.GetString("UpdateDeltaAnalysisFlag", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to UPDATE Vulnerabilities SET  WHERE Vulnerability_ID = @Vulnerability_ID;.
        /// </summary>
        internal static string UpdateVulnerability {
            get {
                return ResourceManager.GetString("UpdateVulnerability", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to UPDATE VulnerabilitySources SET  WHERE Vulnerability_Source_ID = @Vulnerability_Source_ID;.
        /// </summary>
        internal static string UpdateVulnerabilitySource {
            get {
                return ResourceManager.GetString("UpdateVulnerabilitySource", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SELECT Vulnerability_ID, Release FROM Vulnerabilities_VulnerabilitySources NATURAL JOIN Vulnerabilities NATURAL JOIN VulnerabilitySources WHERE Unique_Vulnerability_Identifier = @Unique_Vulnerability_Identifier AND Vulnerability_Source_ID = @Vulnerability_Source_ID;.
        /// </summary>
        internal static string VerifyVulnerabilityChange {
            get {
                return ResourceManager.GetString("VerifyVulnerabilityChange", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SELECT Vulnerability_Source_ID, Source_Version, Source_Release FROM VulnerabilitySources WHERE Source_Name = @Source_Name;.
        /// </summary>
        internal static string VerifyVulnerabilitySourceChange {
            get {
                return ResourceManager.GetString("VerifyVulnerabilitySourceChange", resourceCulture);
            }
        }
    }
}
