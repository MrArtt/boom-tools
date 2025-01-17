using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRM;
public class VRMAuthoringManager : MonoBehaviour
{
    [HideInInspector]
    public DNAManager dnaManager;

    public string title, creator, contactInformation, reference, version, additionalLicenseInfoURL;

    public bool depictionOfViolence = false, depictionOfSexualActs = false, commercialUse = false ;

    public AllowedUser allowedUser = AllowedUser.OnlyAuthor;
    public LicenseType license = LicenseType.CC0;

    public UssageLicense violentUssage = UssageLicense.Disallow;
    public UssageLicense sexualUssage = UssageLicense.Disallow;
    public UssageLicense commercialUssage = UssageLicense.Allow;

    public bool storeScreenshotsInVRM = false;

}
