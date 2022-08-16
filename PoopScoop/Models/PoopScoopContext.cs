using Microsoft.EntityFrameworkCore;

namespace PoopScoop.Models
{
  public class PoopScoopContext : DbContext
  {
    public PoopScoopContext(DbContextOptions<PoopScoopContext> options)
      : base(options)
      {
        
      }
      public DbSet<Poop> Poops { get; set; }
      
    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Poop>()
      .HasData(
        new Poop { PoopId = 1, Consistency = "Soft", Volume = "Average", Color = "Brown", Content = "None", Coating = "None" , Grade = "A", Problem = "No Problems this is a healthy poop.", Solution = "NA"},
        new Poop { PoopId = 2, Consistency = "Liquid", Volume = "Average", Color = "Brown", Content = "None", Coating = "None" , Grade = "B", Problem = "Excessive scratching and inflamed paws sign of grain allergy", Solution = "24 hours fasting, plain food and probiotics"},
        new Poop { PoopId = 3, Consistency = "Soft", Volume = "Above Average", Color = "Brown", Content = "None", Coating = "None" , Grade = "A-", Problem = "A sudden change may mean your dog is digesting food differently, change in diet, gut inflamation.", Solution = "Monitor for discomfort and speak with your vet if this continues."},
        new Poop { PoopId = 4, Consistency = "Soft", Volume = "Below Average", Color = "Brown", Content = "None", Coating = "None" , Grade = "A-", Problem = "A sudden change may mean your dog is digesting food differently, change in diet, gut inflamation, or obstruction.", Solution = "Monitor for discomfort and speak with your vet if this continues"},
        new Poop { PoopId = 5, Consistency = "Hard", Volume = "Average", Color = "Brown", Content = "None", Coating = "None" , Grade = "B +", Problem = "Dehydration or lack of fibre.", Solution = "Go for a walk with your dog, ensure access to plenty of fresh water"},
        new Poop { PoopId = 6, Consistency = "Soft", Volume = "Average", Color = "Pink or Purple", Content = "None", Coating = "None" , Grade = "F", Problem = "Could indicate HGE or hemorrhagic gastroenteritis.", Solution = "Get an emergency vet appointment"},
        new Poop { PoopId = 7, Consistency = "Soft", Volume = "Average", Color = "Orange or yellow", Content = "None", Coating = "None" , Grade = "D", Problem = "This color can point to an underlying biliary or liver issue", Solution = "Call the vet"},
        new Poop { PoopId = 8, Consistency = "Soft", Volume = "Average", Color = "Green", Content = "None", Coating = "None" , Grade = "C", Problem = "Could be your dog has eaten too much grass, has a gallbladder issue, or has parasites.", Solution = "Monitor for discomfort and speak with a vet if severe or persistent"},
        new Poop { PoopId = 9, Consistency = "Soft", Volume = "Average", Color = "Grey", Content = "None", Coating = "Greasy" , Grade = "B-", Problem = "Could indicate biliary or pancreatic problem.", Solution = "Could be a sign you're feeding too much fat, and may need to switch up their diet"},
        new Poop { PoopId = 10, Consistency = "Soft", Volume = "Average", Color = "Black", Content = "None", Coating = "None" , Grade = "D-", Problem = "Can be a sign of bleeding in the upper GI tract", Solution = "Poop is black because blood has been digested- a sign you should get your dog to a vet."},
        new Poop { PoopId = 11, Consistency = "Soft", Volume = "Average", Color = "White", Content = "None", Coating = "None" , Grade = "B", Problem = "Maybe a result of diet.", Solution = "Maybe a result of diet, food high in calcium or recent switch to raw food."},
        new Poop { PoopId = 12, Consistency = "Soft", Volume = "Average", Color = "Brown", Content = "Rice-Like Polka-Dots", Coating = "None" , Grade = "C-", Problem = "Keep an eye out for critters.", Solution = "At the sign of skinny roundworms, or little-rice-shaped tapeworm segments, reach for the dewormer."},
        new Poop { PoopId = 13, Consistency = "Soft", Volume = "Average", Color = "Brown", Content = "Red Streaks", Coating = "None" , Grade = "D", Problem = "Could indicate presence of blood and needs investigating.", Solution = "If poop is normal in consistency it is likely caused by a tear or trauma in their bottom."  },
        new Poop { PoopId = 14, Consistency = "Soft", Volume = "Average", Color = "Brown", Content = "Grass and Random Stuff", Coating = "None" , Grade = "C", Problem = "Poop including grass or bits of clothing, plastic, and other unusual items.", Solution = "If you items are stuck in their digestive tract get an x-ray pronto"},
        new Poop { PoopId = 15, Consistency = "Soft", Volume = "Average", Color = "Brown", Content = "Fur", Coating = "None" , Grade = "C", Problem = "A sign of over grooming, a dogs way of coping with everything from allergies to stress and anxiety.", Solution = "Reduce stressors and ease them into any changes gradually."},
        new Poop { PoopId = 16, Consistency = "Soft", Volume = "Average", Color = "Brown", Content = "None", Coating = "Mucus" , Grade = "C-", Problem = "Mucus is a sign of inflamation which can be caused by things such as parasites, food intolerances, and bacterial infections.", Solution = "Food intolerance can require dietary changes and probiotics, in serious cases antibiotics and steroids may be required."}
   
      );
    }
  }
}