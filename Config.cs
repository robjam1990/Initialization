using System;
using System.IO;
using Newtonsoft.Json;


    [Serializable]
public class GameConfig
{
    private string configPath;

    public bool WindowTitle { get; private set; }

#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
    public GameConfig(string configPath)
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
    {
        try
        {
            string json = File.ReadAllText(configPath);
            dynamic configData = JsonConvert.DeserializeObject(json)!;
            // Validate configData here
            foreach (var property in configData)
            {
                string propertyName = ((Newtonsoft.Json.Linq.JProperty)property).Name;
                object propertyValue = ((Newtonsoft.Json.Linq.JProperty)property).Value;
                typeof(GameConfig).GetProperty(propertyName)?.SetValue(this, propertyValue, null);
            }
        }
        catch (Exception error)
        {
            Console.WriteLine("Error loading configuration: " + error.Message);
            // Handle error gracefully or throw it
        }
    }

    public class GameConfigDefaults
    {
        // Game directories
        public string HomeDirectory { get; set; } = "C://./Psychosis/"; // Home directory
        public string ResourcesDirectory { get; set; } = "C:// /Psychosis/Resources/"; // Resources directory
        public string DataDirectory { get; set; } = "C:// /Psychosis/Data/"; // Data directory
        public string SaveDirectory { get; set; } = "C:// /Psychosis/Save/";    // Save directory
        public string LogDirectory { get; set; } = "C:// /Psychosis/Log/"; // Log directory
        public string ConfigDirectory { get; set; } = "C:// /Psychosis/Config/"; // Configuration directory
        public string TempDirectory { get; set; } = "C:// /Psychosis/Temp/";    // Temporary directory
        public string AssetDirectory { get; set; } = "C:// /Psychosis/Asset/"; // Asset directory
        public string ScriptDirectory { get; set; } = "C:// /Psychosis/Script/"; // Script directory
        public string PluginDirectory { get; set; } = "C:// /Psychosis/Plugin/"; // Plugin directory
        public string ModDirectory { get; set; } = "C:// /Psychosis/Mod/"; // Mod directory

        // Window settings
        public string WindowTitle { get; set; } = "Psychosis Window";   // Default window title
        public string WindowIcon { get; set; } = "Thear.png";   // Default window icon
        public int MaxWindowWidth { get; set; } = 800; // Default maximum window width
        public int MaxWindowHeight { get; set; } = 600; // Default maximum window height
        public int InitialWindowWidth { get; set; } = 600; // Default initial window width
        public int InitialWindowHeight { get; set; } = 400; // Default initial window height
        public bool WindowResizable { get; set; } = true; // Default window resizable
        public bool WindowBorderless { get; set; } = false; // Default window borderless
        public bool WindowAlwaysOnTop { get; set; } = false;    // Default window always on top
        public bool WindowVSync { get; set; } = true; // Default window VSync

        // Rendering settings
        public int[] RenderDefaultBackgroundColor { get; set; } = new int[] { 255, 255, 255 }; // White color
        public int RenderDefaultLayer { get; set; } = 0;    // Default render layer
        public int RenderFPS { get; set; } = 60; // Default render FPS
        public bool RenderVSync { get; set; } = true; // Default render VSync
        public bool RenderFullscreen { get; set; } = false; // Default render fullscreen
        public bool RenderAntialiasing { get; set; } = true; // Default render antialiasing
        public bool RenderTexture { get; set; } = true; // Default render texture
        public bool RenderPostProcessing { get; set; } = true; // Default render post-processing
        public bool RenderBloom { get; set; } = true; // Default render bloom

        // Game features
        public bool LimbRemovalEnabled { get; set; } = true; // Added Limb Removal
        public bool EcosystemSimulationEnabled { get; set; } = true; // Added Ecosystem Simulation
        public bool NationBuildingEnabled { get; set; } = true; // Added Nation Building
        public bool SocialInfrastructureEnabled { get; set; } = true; // Added Social Infrastructure
        public bool BountySystemEnabled { get; set; } = true; // Added Bounty System
        public bool HierarchySystemEnabled { get; set; } = true; // Added Hierarchy System
        public bool IndividualLoyaltyEnabled { get; set; } = true; // Added Individual Loyalty
        public bool TerritoryBorderExpansionEnabled { get; set; } = true; // Added Territory Border Expansion
        public bool DayNightCycleEnabled { get; set; } = true; // Added Day-Night Cycle
        public bool ConstructionSystemEnabled { get; set; } = true; // Added Construction System
        public bool PrisonerSystemEnabled { get; set; } = true; // Added Prisoner System
        public bool HiringSystemEnabled { get; set; } = true; // Added Hiring System
        public bool SupplyAndDemandSystemEnabled { get; set; } = true; // Added Supply and Demand System
        public bool ResourceSystemEnabled { get; set; } = true; // Added Resource System
        public bool CraftingSystemEnabled { get; set; } = true; // Added Crafting System
        public bool SurvivalSystemEnabled { get; set; } = true; // Added Survival System
        public bool CharacterGrowthSystemEnabled { get; set; } = true; // Added User Growth System
        public bool LearningAndTeachingSystemEnabled { get; set; } = true; // Added Learning and Teaching System
        public bool ObservationSystemEnabled { get; set; } = true; // Added Observation System
        public bool CharacterCustomizationEnabled { get; set; } = true;     // Added User Customization
        public bool GeneticManipulationEnabled { get; set; } = true; // Added Genetic Manipulation
        public bool NeuralNetworkEnabled { get; set; } = true; // Added Neural Network
        public bool ContractBoardEnabled { get; set; } = true; // Added Contract Board
        public bool ModelStrategyEnabled { get; set; } = true; // Added Model Strategy
        public bool MercenaryEnabled { get; set; } = true; // Added Mercenary
        public bool NPCEnabled { get; set; } = true; // Added NPC
        public bool ArkEnabled { get; set; } = true; // Added Ark
        public bool CharacterEnabled { get; set; } = true; // Added User
        public bool CharacterCreationEnabled { get; set; } = true; // Added User Creation
        public bool CharacterDevelopmentEnabled { get; set; } = true; // Added User Development
        public bool CharacterInteractionEnabled { get; set; } = true; // Added User Interaction
    }

    class Program
    {
        private static string configPath = "./config.json";
        static void Main(string[] args)
        {
            GameConfig config = new GameConfig(configPath);
            config.UpdateConfig(new { WindowTitle = "New Title" }); // Updating a specific setting
            Console.WriteLine(config.WindowTitle); // Accessing the updated setting
        }
    }

    private void UpdateConfig(object value)
    {
        foreach (var property in value.GetType().GetProperties())
        {
            typeof(GameConfig).GetProperty(property.Name)?.SetValue(this, property.GetValue(value), null);

            // Save the updated configuration to the config file
            SaveConfig();
        }

        void SaveConfig()
        {
            try
            {
                string json = JsonConvert.SerializeObject(this, Formatting.Indented);
                File.WriteAllText(configPath, json);
            }
            catch (Exception error)
            {
                Console.WriteLine("Error saving configuration: " + error.Message);
                // Handle error gracefully or throw it
            }
        }
    }
}


// Define Model Configuration
public class ModelConfig
{
    public double BaseLearningRate { get; set; }
    public string? Target { get; set; }
    public double ExplorationFactor { get; set; }
    public double CombatFactor { get; set; }
    public int NumTimesteps { get; set; }
    public int LogEveryT { get; set; }
}

// Define Features Configuration
public class FeaturesConfig
{
    public Dictionary<string, double>? CharacterTraits { get; set; }
    public Dictionary<string, bool>? EnvironmentSettings { get; set; }
    public Dictionary<string, bool>? SocialSystem { get; set; }
    public Dictionary<string, bool>? CombatSystem { get; set; }
    public Dictionary<string, bool>? CraftingSystem { get; set; }
    public Dictionary<string, bool>? SurvivalSystem { get; set; }
    public Dictionary<string, bool>? CharacterProgression { get; set; }
    public Dictionary<string, bool>? CustomizationSystem { get; set; }
    public Dictionary<string, bool>? ResourceManagement { get; set; }
    public Dictionary<string, bool>? NationBuilding { get; set; }
    public bool GeneticManipulation { get; set; }
    public bool EcosystemSimulation { get; set; }
    public bool CommunicationSystem { get; set; }
    public bool AnimalDomestication { get; set; }
    public bool TerritoryClaiming { get; set; }
    public bool LocationManagement { get; set; }
    public bool PlayerHousing { get; set; }
    public bool DelegationSystem { get; set; }
    public bool PrisonerManagement { get; set; }
    public bool ArmyManagement { get; set; }
}
public class Config
{
    public Config()
    {
        // Define game configuration
        GameConfig gameConfig = new GameConfig
        {
            Name = "Psychosis",
            Setting = "Thear",
            Genre = "Adventure-RPG",
            Version = "0.8"
        };

        // Define model configuration
        ModelConfig modelConfig = new ModelConfig
        {
            BaseLearningRate = 1.0e-04,
            Target = "LatentDiffusionModel",
            ExplorationFactor = 0.75,
            CombatFactor = 0.25,
            NumTimesteps = 1000,
            LogEveryT = 200
        };

        // Define features configuration
        FeaturesConfig featuresConfig = new FeaturesConfig
        {
            CharacterTraits = new Dictionary<string, double>
            {
                { "loyalty", 0.5 },
                { "fear", 0.3 },
                { "respect", 0.7 },
                { "morality", 0.6 }
            },
            EnvironmentSettings = new Dictionary<string, bool>
            {
                { "timeCycle", true },
                { "seasonCycle", true },
                { "territoryExpansion", true },
                { "structureManagement", true }
            },
            SocialSystem = new Dictionary<string, bool>
            {
                { "hierarchyCreation", true },
                { "bountySystem", true },
                { "loyaltyManagement", true },
                { "communityInteraction", true },
                { "factionSystem", true },
                { "reputationSystem", true },
                { "diplomacySystem", true }
            },
            // Add more dictionaries for other systems
            // For brevity, omitted here
        };
    }

    public class GameConfig()
    {
        public string Name { get; set; } = "Psychosis";
        public string Setting { get; set; } = "Thear";
        public string Genre { get; set; } = "Adventure-RPG";
        public string Version { get; set; } = "0.8";


        public GameConfig(string name, string setting, string genre, string version)
            : this()
        {
            Name = name;
            Setting = setting;
            Genre = genre;
            Version = version;
        }
    }
}
