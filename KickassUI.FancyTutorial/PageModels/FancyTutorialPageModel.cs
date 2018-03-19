using System;
using System.Collections.Generic;
using FreshMvvm;
using KickassUI.FancyTutorial.Models;

namespace KickassUI.FancyTutorial.PageModels
{
    public class FancyTutorialPageModel : FreshBasePageModel
    {
        public List<TutorialItem> TutorialItems { get; set; }

        public FancyTutorialPageModel()
        {
            TutorialItems = new List<TutorialItem>{
                new TutorialItem{ ImageUrl="stock.jpg", Title="Welcome", Subtitle="TO THIS TASTEFUL LOOKING TUTORIAL", Text="Just look at that awesome plate filled with tomatoes, rucola and some sort of white coleslaw looking thing. I don't like coleslaw. Really don't."},
                new TutorialItem{ ImageUrl="stock2.jpg", Title="Churros!", Subtitle="YOU GOTTA LOVE THESE", Text="Churros oh churros, my favorite cakes, dipped in cinnamon and oh so sweet. Some are long, some are short, but they are all tasty and that's why I love them."},
                new TutorialItem{ ImageUrl="stock3.jpg", Title="Muffins", Subtitle="THEY LOOK LIKE CAKES", Text="I love you with coffee, I love you with tea, I love that you're so very yummy. Don't care if you're iced, topped with crumbles, or bare As long as you get in my tummy."},
            };
        }
    }
}
