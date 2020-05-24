using System.ComponentModel;

namespace Vulnerator.Model.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("StepOneQuestionnaire")]
    public partial class StepOneQuestionnaire : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public StepOneQuestionnaire()
        {
            Groups = new HashSet<Group>();
            Connectivities = new HashSet<Connectivity>();
            DitprDonNumbers = new HashSet<DitprDonNumber>();
            ExternalSecurityServices = new HashSet<ExternalSecurityService>();
            EncryptionTechniques = new HashSet<EncryptionTechnique>();
            NetworkConnectionRules = new HashSet<NetworkConnectionRule>();
            UserCategories = new HashSet<UserCategory>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long StepOneQuestionnaire_ID { get; set; }

        [Required]
        [StringLength(2000)]
        public string SystemDescription { get; set; }

        [Required]
        [StringLength(2000)]
        public string MissionDescription { get; set; }

        [Required]
        [StringLength(2000)]
        public string CONOPS_Statement { get; set; }

        [Required]
        [StringLength(5)]
        public string IsTypeAuthorization { get; set; }

        [Required]
        [StringLength(25)]
        public string RMF_Activity { get; set; }

        public long Accessibility_ID { get; set; }

        public long Overview_ID { get; set; }

        [Required]
        [StringLength(25)]
        public string PortsProtocolsRegistrationNumber { get; set; }

        public long AuthorizationInformation_ID { get; set; }

        public long FISMA_ID { get; set; }

        public long Business_ID { get; set; }

        [Required]
        [StringLength(2000)]
        public string SystemEnterpriseArchitecture { get; set; }

        public long? AuthorizationToConnectOrInterim_ATC_ID { get; set; }

        [Required]
        [StringLength(50)]
        public string NIST_ControlSet { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Group> Groups { get; set; }

        public virtual AuthorizationToConnectOrInterim_ATC AuthorizationToConnectOrInterim_ATC { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Connectivity> Connectivities { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DitprDonNumber> DitprDonNumbers { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ExternalSecurityService> ExternalSecurityServices { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EncryptionTechnique> EncryptionTechniques { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NetworkConnectionRule> NetworkConnectionRules { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UserCategory> UserCategories { get; set; }
    }
}
