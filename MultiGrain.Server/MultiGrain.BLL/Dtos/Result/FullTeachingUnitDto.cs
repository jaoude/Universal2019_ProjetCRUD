using System;
using System.Collections.Generic;
using System.Text;

namespace MultiGrain.BLL.Dtos.Result
{
    public class ListFullTeachingUnitDto
    {
       public List<FullTeachingUnitDto> list { get; set; }
        public ListFullTeachingUnitDto()
        {
            list = new List<FullTeachingUnitDto>();
            list.Add(new FullTeachingUnitDto("1", "1", "Analyse 1", "5", "Obligatoire", "275C-7.5D", "7 Catalogues", "INCI", "Program 1", "2017"));
            list.Add(new FullTeachingUnitDto("2", "1", "Algèbre", "5", "Optionnelle USJ", "275C-7.5D", "7 Catalogues", "INCI", "Program 1", "2017"));
            list.Add(new FullTeachingUnitDto("3", "1", "Circuits logiques", "6", "Optionnelle ouverte", "275C-7.5D", "7 Catalogues", "INCI", "Program 1", "2017"));
            list.Add(new FullTeachingUnitDto("4", "1", "Architecture des ordinateurs", "5", "Optionnelle fermée", "275C-7.5D", "7 Catalogues", "INCI", "Program 1", "2018"));
            list.Add(new FullTeachingUnitDto("5", "1", "Analyse 2", "5", "Obligatoire", "275C-7.5D", "7 Catalogues", "INCI", "Program 2", "2018"));
            list.Add(new FullTeachingUnitDto("6", "1", "Mathématiques discrètes", "5", "Optionnelle fermée", "275C-7.5D", "7 Catalogues", "INCI", "Program 2", "2018"));
            list.Add(new FullTeachingUnitDto("7", "1", "Réseaux et systèmes linéaires 1", "6", "Optionnelle USJ", "275C-7.5D", "7 Catalogues", "INCI", "Program 2", "2017"));
            list.Add(new FullTeachingUnitDto("8", "1", "Probabilité et statistiques", "5", "Optionnelle ouverte", "275C-7.5D", "10 Catalogues", "INCI", "Program 2", "2018"));
            list.Add(new FullTeachingUnitDto("9", "1", "Informatique 2", "6", "Obligatoire", "275C-7.5D", "10 Catalogues", "INCI", "Program 2", "2018"));
    list.Add(new FullTeachingUnitDto("10", "1", "Technologies WEB", "3", "Obligatoire", "275C-7.5D", "10 Catalogues", "INCI", "Program 4", "2017"));
            list.Add(new FullTeachingUnitDto("11", "1", "Informatique 1", "5", "Optionnelle ouverte", "275C-7.5D", "10 Catalogues", "INCI", "Program 5", "2017"));
            list.Add(new FullTeachingUnitDto("12", "1", "Expression et communication", "2", "Optionnelle fermée", "275C-7.5D", "10 Catalogues", "INCI", "Program 6", "2017"));
            list.Add(new FullTeachingUnitDto("13", "1", "Comptabilité Générale", "2", "Optionnelle USJ", "275C-7.5D", "10 Catalogues", "INCI", "Program 6", "2017"));
            list.Add(new FullTeachingUnitDto("14", "1", "Secure Coding", "2", "Obligatoire", "30.0C-30.0T", "10 Catalogues", "INCI", "Program 6", "2019"));
            list.Add(new FullTeachingUnitDto("15", "2", "Programmation orientée objets", "5", "Optionnelle USJ", "30.0C-30.0T", "10 Catalogues", "INCI", "Program 7", "2018"));
            list.Add(new FullTeachingUnitDto("16", "2", "Introduction aux réseaux", "5", "Reprise", "30.0C-30.0T", "10 Catalogues", "INCI", "Program 7", "2018"));
            list.Add(new FullTeachingUnitDto("17", "2", "Génie logiciel", "6", "Optionnelle fermée", "30.0C-30.0T", "10 Catalogues", "INCI", "Program 7", "2018"));
            list.Add(new FullTeachingUnitDto("18", "1", "Structures de données et algorithmes", "6", "Optionnelle ouverte", "30.0C-30.0T", "10 Catalogues", "INCI", "Program 7", "2018"));
            list.Add(new FullTeachingUnitDto("19", "2", "Architecture des systèmes d'exploitation", "5", "Reprise", "30.0C-30.0T", "2 Catalogues", "INCI", "Program 7", "2018"));
            list.Add(new FullTeachingUnitDto("21", "1", "Ethique", "2", "Optionnelle ouverte", "30.0C-30.0T", "2 Catalogues", "INCI", "Program 5", "2019"));
            list.Add(new FullTeachingUnitDto("22", "2", "Bases de données 1", "5", "Reprise", "30.0C-30.0T", "2 Catalogues", "INCI", "Program 4", "2019"));
            list.Add(new FullTeachingUnitDto("23", "2", "Concepts économiques", "2", "Optionnelle fermée", "30.0C-30.0T", "2 Catalogues", "INCI", "Program 7", "2018"));
            list.Add(new FullTeachingUnitDto("24", "2", "Design Patterns", "6", "Optionnelle USJ", "30.0C-30.0T", "2 Catalogues", "INCI", "Program 3", "2019"));
            list.Add(new FullTeachingUnitDto("25", "2", "Programmation iOS", "6", "Obligatoire", "30.0C-30.0T", "2 Catalogues", "INCI", "Program 1", "2019"));
            list.Add(new FullTeachingUnitDto("26", "2", "Programmation parallèle", "5", "Optionnelle fermée", "30.0C-30.0T", "2 Catalogues", "INCI", "Program 2", "2019"));
            list.Add(new FullTeachingUnitDto("27", "1", "Intelligence artificielle", "5", "Obligatoire", "30.0C-30.0T", "8 Catalogues", "INCI", "Program 2", "2019"));
            list.Add(new FullTeachingUnitDto("28", "2", "Management", "2", "Obligatoire", "30.0C-30.0T", "8 Catalogues", "INCI", "Program 6", "2019"));
            list.Add(new FullTeachingUnitDto("29", "1", "Les églises orientales", "2", "Optionnelle ouverte", "30.0C-30.0T", "8 Catalogues", "INCI", "Program 6", "2018"));
            list.Add(new FullTeachingUnitDto("30", "1", "Électromagnétisme", "5", "Obligatoire", "17.5C", "8 Catalogues", "INCI", "Program 4", "2018"));
            list.Add(new FullTeachingUnitDto("31", "2", "Électronique analogique 2", "5", "Obligatoire", "17.5C", "8 Catalogues", "INCI", "Program 7", "2019"));
            list.Add(new FullTeachingUnitDto("32", "2", "Électronique numérique", "5", "Optionnelle fermée", "17.5C", "5 Catalogues", "INCI", "Program 3", "2018"));
            list.Add(new FullTeachingUnitDto("33", "1", "Électronique analogique 1", "6", "Reprise", "17.5C", "5 Catalogues", "INCI", "Program 4", "2018"));
            list.Add(new FullTeachingUnitDto("34", "1", "Réseaux et systèmes linéaires 2", "5", "Optionnelle USJ", "17.5C", "5 Catalogues", "INCI", "Program 4", "2018"));
            list.Add(new FullTeachingUnitDto("35", "1", "Théorie et traitement du signal", "6", "Reprise", "30.2A-10.25T", "5 Catalogues", "INCI", "Program 4", "2019"));
            list.Add(new FullTeachingUnitDto("36", "2", "Introduction au routage et à la commutation", "5", "Optionnelle ouverte", "30.2A-10.25T", "5 Catalogues", "INCI", "Program 4", "2019"));
            list.Add(new FullTeachingUnitDto("37", "2", "Systèmes de communication", "6", "Reprise", "30.2A-10.25T", "5 Catalogues", "INCI", "Program 4", "2018"));
            list.Add(new FullTeachingUnitDto("38", "2", "Propagation guidée, an10nes et circuits hyperfréquences", "6", "Optionnelle ouverte", "30.2A-10.25T", "4 Catalogues", "INCI", "Program 4", "2019"));
            list.Add(new FullTeachingUnitDto("39", "2", "Microprocesseurs", "5", "Obligatoire", "30.2A-10.25T", "4 Catalogues", "INCI", "Program 5", "2018"));
            list.Add(new FullTeachingUnitDto("40", "2", "Projet informatique", "5", "Optionnelle fermée", "30.2A-10.25T", "4 Catalogues", "INCI", "Program 5", "2019"));
            list.Add(new FullTeachingUnitDto("41", "1", "Anglais niveau A", "4", "Optionnelle fermée", "30.2A-10.25T", "4 Catalogues", "INCI", "Program 5", "2019"));
            list.Add(new FullTeachingUnitDto("42", "2", "Bases de données 2", "5", "Obligatoire", "18.75C", "4 Catalogues", "INCI", "Program 5", "2019"));
            list.Add(new FullTeachingUnitDto("43", "1", "Communication Non Violante", "2", "Optionelle", "18.75C", "4 Catalogues", "INCI", "Program 5", "2018"));
            list.Add(new FullTeachingUnitDto("44", "2", "Marketing", "2", "Optionnelle USJ", "18.75C", "4 Catalogues", "INCI", "Program 5", "2019"));
            list.Add(new FullTeachingUnitDto("45", "1", "Réseaux dentreprise étendus", "5", "Optionnelle fermée", "40.27C-53.2D", "4 Catalogues", "INCI", "Program 1", "2019"));
            list.Add(new FullTeachingUnitDto("46", "2", "Systèmes d'exploitation Windows et UNIX", "5", "À ajouter", "40.27C-53.2D", "1 Catalogue", "INCI", "Program 1", "2019"));
            list.Add(new FullTeachingUnitDto("47", "1", "Principes des Compilateurs", "5", "Obligatoire", "40.27C-53.2D", "6 Catalogues", "INCI", "Program 1", "2019"));
            list.Add(new FullTeachingUnitDto("48", "2", "Web dynamique", "5", "Obligatoire", "40.27C-53.2D", "14 Catalogues", "INCI", "Program 1", "2019"));
            list.Add(new FullTeachingUnitDto("49", "1", "Stage en entreprise", "14", "Obligatoire", "40.27C-53.2D", "3 Catalogues", "INCI", "Program 1", "2020"));

        }
    }
   public class FullTeachingUnitDto
    {
        public FullTeachingUnitDto(string id, string semestre, string title, string
            credits, string mode, string cygle, string catalog, string instituion, string program,string year)
        {
            this.id = id;
            this.semestre = semestre;
            this.title = title;
            this.credits = credits;
            this.mode = mode;
            this.cygle = cygle;
            this.catalog = catalog;
            this.instituion = instituion;
            this.program = program;
            this.year = year;
        }
        public string id { get; set; }
        public string semestre { get; set; }
        public string title { get; set; }
        public string credits { get; set; }
        public string mode { get; set; }
        public string cygle { get; set; }
        public string catalog { get; set; }

        public string instituion { get; set; }
        public string program { get; set; }

        public string year { get; set; }
        //    Id :number;
        //semestre: number;
        //title: string;
        //credits: string;
        //mode: string;
        //cygle: string;
        //catalognumb: string;
    }
}
