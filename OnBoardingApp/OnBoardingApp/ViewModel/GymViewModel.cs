using System;
using System.Collections.Generic;
using System.Text;

using OnBoardingApp.Model;

namespace OnBoardingApp.ViewModel
{
  public  class GymViewModel
    {
        public List<Gym> GetItems { get; set; } = new List<Gym>();

       public GymViewModel()
        {
            GetItems = new List<Gym>
            {
                new Gym{ ImagePath="gym_guy.png" , Text="Get Motivated", words="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Pellentesque sollicitudin at erat at fermentum. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia curae;"},
                 new Gym{ ImagePath="gym_time.png" , Text="Set Your Goals", words="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Pellentesque sollicitudin at erat at fermentum. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia curae;"},
                 new Gym{ ImagePath="gym_cycle.png" , Text="Do it Yourself", words="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Pellentesque sollicitudin at erat at fermentum. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia curae;"}


            };
                  
            
            }

    }
}
