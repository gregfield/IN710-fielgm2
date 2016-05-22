using DogSelector.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DogSelector.Controllers
{
    public class DogSelectController : Controller
    {
        // GET: DogSelect
        public ActionResult ShowSelect()
        {
            return View();
        }

        [HttpPost]
        public ActionResult DogRecomendation()
        {
            return View("ShowSelect");
        }
        //what happens when form button clicked
        [HttpPost]
        public ActionResult ShowSelect(bool GoodWithChildren, bool Drooling, ELength CoatLength, EScale ActivityLevel, 
            EScale SheddingLevel, EScale GroomingLevel, EScale IntelligenceLevel, ESize Size)
        {
            //makes the wanted dog
            Dog wantedDog = new Dog
            {
                ActivityLevel = ActivityLevel,
                SheddingLevel = SheddingLevel,
                GroomingLevel = GroomingLevel,
                IntelligenceLevel = IntelligenceLevel,
                GoodWithChildren = GoodWithChildren,
                Drools = Drooling,
                CoatLength = CoatLength,
                Size = Size
            };

            //calls method to find closest dog
            Dog closestMatch = findClosestMatch(wantedDog);

            //returns the view and dog
            return View("DogRecomendation", closestMatch);
        }

        public Dog findClosestMatch(Dog wantedDog)
        {
            //makes dog list
            List<Dog> dogList = new List<Dog>();
            dogList = makeDogList();

            Dog closestMatch = new Dog();

            double highestMatchValue = 0;
            foreach(Dog dog in dogList)
            {
                //calls methods to assign values to find closest match
                double dogValue = 0;
                dogValue += getBoolValue(wantedDog.GoodWithChildren, dog.GoodWithChildren);
                dogValue += getBoolValue(wantedDog.Drools, dog.Drools);
                dogValue += getELengthValue(wantedDog.CoatLength, dog.CoatLength);
                dogValue += getEScaleValue(wantedDog.ActivityLevel, dog.ActivityLevel);
                dogValue += getEScaleValue(wantedDog.SheddingLevel, dog.SheddingLevel);
                dogValue += getEScaleValue(wantedDog.GroomingLevel, dog.GroomingLevel);
                dogValue += getEScaleValue(wantedDog.IntelligenceLevel, dog.IntelligenceLevel);
                dogValue += getESizeValue(wantedDog.Size, dog.Size);

                //if the current dog has a higher match value than the previous highest it now becomes the highest
                if(dogValue > highestMatchValue)
                {
                    highestMatchValue = dogValue;
                    closestMatch = dog;
                }
            }

            return closestMatch;
        }

        //if the bool option are the same assigns 1 else 0
        public double getBoolValue(bool wantedDogInput, bool listDogInput)
        {
            double value = 0;

            if(wantedDogInput == listDogInput)
            {
                value = 1;
            }
            
            return value;
        }

        //if values are the same assign 1
        //if it is not medium means must be either short or long
        //and if the list dog is medium assigns .5 for close
        public double getELengthValue(ELength wantedDogInput, ELength listDogInput)
        {
            double value = 0;

            if(wantedDogInput == listDogInput)
            {
                value = 1;
            }
            if((wantedDogInput != ELength.Medium)&&(listDogInput == ELength.Medium))
            {
                value = 0.5;
            }

            return value;
        }

        //if values are the same or there is no preference for wanted assign 1
        //if it is not medium means must be either short or long
        //and if the list dog is medium assigns .5 for close
        public double getEScaleValue(EScale wantedDogInput, EScale listDogInput)
        {
            double value = 0;

            if (wantedDogInput == listDogInput)
            {
                value = 1;
            }
            if(wantedDogInput == EScale.NoPreference)
            {
                value = 1;
            }
            if (wantedDogInput != EScale.NoPreference)
            {
                if ((wantedDogInput != EScale.Medium) && (listDogInput == EScale.Medium))
                {
                    value = 0.5;
                }
            }

            return value;
        }

        //if values are the same assign 1
        //if it is not the same and it is 1 off either way
        // 0.5 is assigned because it is close
        public double getESizeValue(ESize wantedDogInput, ESize listDogInput)
        {
            double value = 0;

            if (wantedDogInput == listDogInput)
            {
                value = 1;
            }
            if (wantedDogInput == (listDogInput - 1) || wantedDogInput == (listDogInput + 1))
            {
                value = 0.5;
            }

            return value;
        }

        public List<Dog> makeDogList()
        {
            List<Dog> newDatabase = new List<Dog>();

            Dog afghanHound = new Dog();
            afghanHound.BreedName = "afghanHound";
            afghanHound.DisplayName = "Afghan Hound";
            afghanHound.ActivityLevel = EScale.High;
            afghanHound.CoatLength = ELength.Long;
            afghanHound.Drools = false;
            afghanHound.GoodWithChildren = false;
            afghanHound.GroomingLevel = EScale.High;
            afghanHound.IntelligenceLevel = EScale.Low;
            afghanHound.SheddingLevel = EScale.High;
            afghanHound.Size = ESize.Large;
            afghanHound.ImageName = "/images/AfghanHound.jpg";
            newDatabase.Add(afghanHound);


            Dog bassetHound = new Dog();
            bassetHound.BreedName = "BassetHound";
            bassetHound.DisplayName = "Basset Hound";
            bassetHound.ActivityLevel = EScale.Medium;
            bassetHound.CoatLength = ELength.Short;
            bassetHound.Drools = true;
            bassetHound.GoodWithChildren = true;
            bassetHound.GroomingLevel = EScale.Low;
            bassetHound.IntelligenceLevel = EScale.Medium;
            bassetHound.SheddingLevel = EScale.Low;
            bassetHound.Size = ESize.Medium;
            bassetHound.ImageName = "/images/BassetHound.jpg";
            newDatabase.Add(bassetHound);

            Dog beagle = new Dog()
            {
                BreedName = "Beagle",
                DisplayName = "Beagle",
                ActivityLevel = EScale.High,
                CoatLength = ELength.Short,
                Drools = false,
                GoodWithChildren = true,
                GroomingLevel = EScale.Medium,
                IntelligenceLevel = EScale.Medium,
                SheddingLevel = EScale.Low,
                Size = ESize.Medium,
                ImageName = "/images/Beagle.jpg"
            };
            newDatabase.Add(beagle);

            Dog bichonFrise = new Dog()
            {
                BreedName = "BichonFrise",
                DisplayName = "Bichon Frise",
                ActivityLevel = EScale.High,
                CoatLength = ELength.Medium,
                Drools = false,
                GoodWithChildren = true,
                GroomingLevel = EScale.High,
                IntelligenceLevel = EScale.High,
                SheddingLevel = EScale.Low,
                Size = ESize.Small,
                ImageName = "/images/Bichonfrise.jpg"
            };
            newDatabase.Add(bichonFrise);



            Dog borzoi = new Dog()
            {
                BreedName = "Borzoi",
                DisplayName = "Borzoi",
                ActivityLevel = EScale.High,
                CoatLength = ELength.Long,
                Drools = false,
                GoodWithChildren = false,
                GroomingLevel = EScale.High,
                IntelligenceLevel = EScale.High,
                SheddingLevel = EScale.High,
                Size = ESize.Large,
                ImageName = "/images/Borzoi.jpg"
            };
            newDatabase.Add(borzoi);

            Dog bulldog = new Dog()
            {
                BreedName = "Bulldog",
                DisplayName = "Bull Dog",
                ActivityLevel = EScale.Medium,
                CoatLength = ELength.Short,
                Drools = true,
                GoodWithChildren = false,
                GroomingLevel = EScale.Low,
                IntelligenceLevel = EScale.Medium,
                SheddingLevel = EScale.Low,
                Size = ESize.Medium,
                ImageName = "/images/Bulldog.jpg"
            };
            newDatabase.Add(bulldog);


            Dog cav = new Dog()
            {
                BreedName = "CavalierKingCharlesSpaniel",
                DisplayName = "Cavalier King Charles Spaniel",
                ActivityLevel = EScale.Medium,
                CoatLength = ELength.Medium,
                Drools = false,
                GoodWithChildren = true,
                GroomingLevel = EScale.High,
                IntelligenceLevel = EScale.Medium,
                SheddingLevel = EScale.Medium,
                Size = ESize.Small,
                ImageName = "/images/CavalierKingCharlesSpaniel.jpg"
            };
            newDatabase.Add(cav);


            Dog chowchow = new Dog()
            {
                BreedName = "Chowchow",
                DisplayName = "Chow Chow",
                ActivityLevel = EScale.Medium,
                CoatLength = ELength.Long,
                Drools = true,
                GoodWithChildren = false,
                GroomingLevel = EScale.High,
                IntelligenceLevel = EScale.High,
                SheddingLevel = EScale.High,
                Size = ESize.Large,
                ImageName = "/images/Chowchow.jpg"
            };
            newDatabase.Add(chowchow);

            Dog dalmation = new Dog()
            {
                BreedName = "Dalmation",
                DisplayName = "Dalmation",
                ActivityLevel = EScale.High,
                CoatLength = ELength.Short,
                Drools = false,
                GoodWithChildren = false,
                GroomingLevel = EScale.Medium,
                IntelligenceLevel = EScale.High,
                SheddingLevel = EScale.Low,
                Size = ESize.Large,
                ImageName = "/images/Dalmation.jpg"
            };
            newDatabase.Add(dalmation);

            Dog goldenRetriever = new Dog()
            {
                BreedName = "GoldenRetriever",
                DisplayName = "Golden Retriever",
                ActivityLevel = EScale.High,
                CoatLength = ELength.Long,
                Drools = false,
                GoodWithChildren = true,
                GroomingLevel = EScale.Medium,
                IntelligenceLevel = EScale.High,
                SheddingLevel = EScale.High,
                Size = ESize.Large,
                ImageName = "/images/GoldenRetriever.jpg"
            };
            newDatabase.Add(goldenRetriever);

            Dog maltese = new Dog()
            {
                BreedName = "Maltese",
                DisplayName = "Maltese",
                ActivityLevel = EScale.High,
                CoatLength = ELength.Long,
                Drools = false,
                GoodWithChildren = true,
                GroomingLevel = EScale.High,
                IntelligenceLevel = EScale.High,
                SheddingLevel = EScale.High,
                Size = ESize.Miniature,
                ImageName = "/images/Maltese.jpg"
            };
            newDatabase.Add(maltese);

            Dog newfoundland = new Dog()
            {
                BreedName = "Newfoundland",
                DisplayName = "Newfoundland",
                ActivityLevel = EScale.High,
                CoatLength = ELength.Long,
                Drools = true,
                GoodWithChildren = true,
                GroomingLevel = EScale.Medium,
                IntelligenceLevel = EScale.High,
                SheddingLevel = EScale.High,
                Size = ESize.Giant,
                ImageName = "/images/newfoundland.jpg"
            };
            newDatabase.Add(newfoundland);

            Dog oldEnglishSheepdog = new Dog()
            {
                BreedName = "OldEnglishSheepdog",
                DisplayName = "Old English Sheepdog",
                ActivityLevel = EScale.High,
                CoatLength = ELength.Long,
                Drools = true,
                GoodWithChildren = true,
                GroomingLevel = EScale.High,
                IntelligenceLevel = EScale.Medium,
                SheddingLevel = EScale.High,
                Size = ESize.Giant,
                ImageName = "/images/OldEnglishSheepdog.jpg"
            };
            newDatabase.Add(oldEnglishSheepdog);

            Dog pug = new Dog()
            {
                BreedName = "Pug",
                DisplayName = "Pug",
                ActivityLevel = EScale.High,
                CoatLength = ELength.Short,
                Drools = false,
                GoodWithChildren = true,
                GroomingLevel = EScale.Low,
                IntelligenceLevel = EScale.Low,
                SheddingLevel = EScale.Low,
                Size = ESize.Miniature,
                ImageName = "/images/Pug.jpg"
            };
            newDatabase.Add(pug);


            Dog westHighlandWhiteTerrier = new Dog()
            {
                BreedName = "WestHighlandWhiteTerrier",
                DisplayName = "West Highland White Terrier",
                ActivityLevel = EScale.High,
                CoatLength = ELength.Medium,
                Drools = false,
                GoodWithChildren = true,
                GroomingLevel = EScale.Medium,
                IntelligenceLevel = EScale.High,
                SheddingLevel = EScale.Medium,
                Size = ESize.Small,
                ImageName = "/images/WestHighlandWhiteTerrier.jpg"
            };
            newDatabase.Add(westHighlandWhiteTerrier);

            return newDatabase;
        }
    }
}