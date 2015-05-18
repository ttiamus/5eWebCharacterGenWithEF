using System;
using Microsoft.Practices.Unity;
using Microsoft.Practices.Unity.Configuration;
using CharacterGen5th.Repositories;
using CharacterGen5th.Bootstraper.Models;
using CharacterGen5th.Models;

namespace CharacterGen5th.App_Start
{
    /// <summary>
    /// Specifies the Unity configuration for the main container.
    /// </summary>
    public class UnityConfig
    {
        #region Unity Container
        private static Lazy<IUnityContainer> container = new Lazy<IUnityContainer>(() =>
        {
            var container = new UnityContainer();
            RegisterTypes(container);
            return container;
        });

        /// <summary>
        /// Gets the configured Unity container.
        /// </summary>
        public static IUnityContainer GetConfiguredContainer()
        {
            return container.Value;
        }
        #endregion

        /// <summary>Registers the type mappings with the Unity container.</summary>
        /// <param name="container">The unity container to configure.</param>
        /// <remarks>There is no need to register concrete types such as controllers or API controllers (unless you want to 
        /// change the defaults), as Unity allows resolving a concrete type even if it was not previously registered.</remarks>
        public static void RegisterTypes(IUnityContainer container)
        {
            // NOTE: To load from web.config uncomment the line below. Make sure to add a Microsoft.Practices.Unity.Configuration to the using statements.
            // container.LoadConfiguration();

            container.RegisterType<IAbilityScoreRepository, AbilityScoreRepository>();
            container.RegisterType<IAlignmentRepository, AlignmentRepository>();
            container.RegisterType<IArmorRepository, ArmorRepository>();
            container.RegisterType<IBackgroundRepository, BackgroundRepository>();
            //container.RegisterType<ICharacterRepository, CharacterRepository>();
            container.RegisterType<IClassRepository, ClassRepository>();
            container.RegisterType<IFeatRepository, FeatRepository>();
            container.RegisterType<IGodRepository, GodRepository>();
            container.RegisterType<IItemRepository, ItemRepository>();
            container.RegisterType<ILanguageRepository, LanguageRepository>();
            container.RegisterType<IRaceRepository, RaceRepository>();
            container.RegisterType<IRacePropertyRepository, RacePropertyRepository>();
            container.RegisterType<ISizeRepository, SizeRepository>();
            container.RegisterType<ISkillRepository, SkillRepository>();
            container.RegisterType<ISpellRepository, SpellRepository>();
            container.RegisterType<IWeaponPropertyRepository, WeaponPropertyRepository>();
            container.RegisterType<IWeaponRepository, WeaponRepository>();

            //Mappings
            container.RegisterType<IBackgroundToItemMappingRepository, BackgroundToItemMappingRepository>();
            container.RegisterType<IBackgroundToLanguageMappingRepository, BackgroundToLanguageMappingRepository>();
            container.RegisterType<IBackgroundToSkillMappingRepository, BackgroundToSkillMappingRepository>();
            container.RegisterType<IClassToAbilityScoreMappingRepository, ClassToAbilityScoreMappingRepository>();
            container.RegisterType<IClassToArmorMappingRepository, ClassToArmorMappingRepository>();
            container.RegisterType<IClassToSavingThrowMappingRepository, ClassToSavingThrowMappingRepository>();
            container.RegisterType<IClassToSpellMappingRepository, ClassToSpellMappingRepository>();
            container.RegisterType<IClassToWeaponMappingRepository, ClassToWeaponMappingRepository>();
            container.RegisterType<IRaceToAbilityScoreMappingRepository, RaceToAbilityScoreMappingRepository>();
            container.RegisterType<IRaceToLanguageMappingRepository, RaceToLanguageMappingRepository>();
            container.RegisterType<IRaceToRacePropertyMappingRepository, RaceToRacePropertyMappingRepository>();
        }
    }
}
