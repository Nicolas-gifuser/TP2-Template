namespace TP2_Template
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenue dans le générateur de faits inusités !");

            int niveauInusité;

            do
            {
                Console.Write("Entrez un niveau d'inusité entre 0 et 5 : ");
            }
            while (!int.TryParse(Console.ReadLine(), out niveauInusité)
                || niveauInusité < 0
                || niveauInusité > 5);

            AfficherFaitInusité(niveauInusité);

            Console.WriteLine();
            Console.WriteLine("Appuyez sur une touche pour fermer la console...");
            Console.ReadKey();
        }

        static void AfficherFaitInusité(int niveauInusité)
        {
            string[] faits =
            {
                // Niveau 0
                "Les girafes n'ont que sept vertèbres dans leur cou, comme les humains.",
                "Les chats peuvent faire pivoter leurs oreilles à 180 degrés.",
                "Les escargots possèdent des milliers de petites dents.",
                "Les kangourous ne peuvent pas marcher à reculons.",
                "Les ours polaires ont la peau noire sous leur fourrure.",
                "Les perroquets peuvent apprendre à imiter la voix humaine.",
                "Les hiboux peuvent tourner leur tête jusqu'à 270 degrés.",
                "Les dauphins dorment avec un seul hémisphère de leur cerveau à la fois.",
                "Les moustiques sont attirés par le dioxyde de carbone.",
                "Les chats passent une grande partie de leur journée à dormir.",

                // Niveau 1
                "Les poulpes possèdent des neurones dans leurs huit bras.",
                "Les girafes peuvent nettoyer leurs oreilles avec leur langue.",
                "Les ours peuvent courir plus vite que certains chevaux sur de courtes distances.",
                "Les cochons ne peuvent pas regarder le ciel sans bouger leur corps.",
                "Les crocodiles avalent parfois des pierres pour faciliter leur digestion.",
                "Les abeilles communiquent la position des fleurs grâce à une danse.",
                "Les manchots offrent parfois des cailloux à leur partenaire.",
                "Les chevaux peuvent dormir debout.",
                "Les rats rient lorsqu'on les chatouille, mais à des fréquences inaudibles pour nous.",
                "Les paresseux peuvent retenir leur respiration plus longtemps que certains dauphins.",

                // Niveau 2
                "Les étoiles de mer n'ont pas de cerveau.",
                "Les wombats produisent des excréments en forme de cubes.",
                "Les flamants roses peuvent manger la tête en bas.",
                "Les fourmis peuvent transporter plusieurs fois leur propre poids.",
                "Les corbeaux sont capables d'utiliser des outils pour obtenir de la nourriture.",
                "Les méduses existent depuis des centaines de millions d'années.",
                "Les lézards peuvent parfois détacher leur queue pour échapper à un prédateur.",
                "Les chauves-souris sont les seuls mammifères capables de voler véritablement.",
                "Les pingouins ont les genoux cachés sous leurs plumes.",
                "Les tortues peuvent respirer par leur cloaque chez certaines espèces.",

                // Niveau 3
                "Les cachalots communiquent avec des séquences de clics appelées codas.",
                "Les crevettes-mantes possèdent une vision des couleurs très différente de la nôtre.",
                "Les grenouilles peuvent absorber de l'eau directement par leur peau.",
                "Certains lézards peuvent courir sur l'eau pendant quelques secondes.",
                "Les requins du Groenland peuvent vivre plusieurs siècles.",
                "Les fourmis cultivent des champignons pour se nourrir.",
                "Les narvals possèdent une longue défense qui est en réalité une dent.",
                "Les corbeaux peuvent résoudre des problèmes en plusieurs étapes.",
                "Les termites construisent des nids capables de réguler leur température.",
                "Certains poissons peuvent changer de sexe au cours de leur vie.",

                // Niveau 4
                "Les axolotls peuvent régénérer leurs membres sans laisser de cicatrices importantes.",
                "Certains lézards peuvent projeter du sang depuis leurs yeux pour se défendre.",
                "Les calmars géants possèdent des yeux de la taille d'un ballon de football.",
                "Les poissons-globes peuvent créer des motifs géométriques dans le sable pour attirer une partenaire.",
                "Les fourmis légionnaires construisent des ponts vivants avec leurs propres corps.",
                "Les cachalots possèdent le plus gros cerveau de tous les animaux connus.",
                "Certains oiseaux peuvent dormir en volant pendant de longues périodes.",
                "Les poissons des glaces de l'Antarctique possèdent des protéines antigel dans leur sang.",
                "Les araignées peuvent utiliser leurs toiles pour se déplacer dans les airs sur de longues distances.",
                "Les pieuvres peuvent modifier la texture de leur peau pour se camoufler.",

                // Niveau 5
                "Certains vers plats peuvent régénérer un organisme complet à partir d'un minuscule fragment de leur corps.",
                "Les tardigrades peuvent entrer dans un état de dormance appelé cryptobiose.",
                "Le champignon Armillaria peut former un organisme souterrain couvrant plusieurs kilomètres carrés.",
                "Certaines espèces de méduses peuvent revenir à un stade de développement plus jeune.",
                "Les fourmis peuvent former des radeaux flottants avec leurs propres corps pour survivre aux inondations.",
                "Certains poissons produisent leur propre lumière grâce à la bioluminescence.",
                "Les plantes carnivores peuvent compter le nombre de contacts avant de fermer leur piège.",
                "Des bactéries peuvent survivre dans des environnements extrêmement acides.",
                "Certains organismes marins vivent près des cheminées hydrothermales sans dépendre directement de la lumière du Soleil.",
                "Les champignons peuvent créer des réseaux souterrains reliant les racines de différentes plantes."
            };

            int premierFaitDuNiveau = niveauInusité * 10;
            Random hasard = new Random();
            int numéroDuFait = premierFaitDuNiveau + hasard.Next(10);

            Console.WriteLine();
            Console.WriteLine($"Fait inusité de niveau {niveauInusité} :");
            Console.WriteLine(faits[numéroDuFait]);
        }
    }
}