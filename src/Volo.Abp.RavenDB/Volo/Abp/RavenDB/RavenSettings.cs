﻿namespace Volo.Abp.RavenDB.Volo.Abp.RavenDB
{
    public class RavenSettings
    {
        /// <summary>
        /// The URLs where the database resides.
        /// </summary>
        public string[] Urls { get; set; }

        /// <summary>
        /// The name of the database.
        /// </summary>
        public string DatabaseName { get; set; }

        /// <summary>
        /// The file path to the PFX certificate to use to connect to Raven. This should be a path relative to <see cref="IHostEnvironment.ContentRootPath"/>. For example, if the cert is named foo.pfx and in the same directory as your deployed assemblies, this should be set to "foo.pfx". If null or empty, no certificate will be used.
        /// </summary>
        public string CertFilePath { get; set; }

        /// <summary>
        /// The password to use for the certificate.
        /// </summary>
        public string CertPassword { get; set; }
    }
}
