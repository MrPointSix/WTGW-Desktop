using TMPro;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;


public class CardGenerator : MonoBehaviour
{
    string[,] wordBank = {
        { "Absorb", "Soak" }, { "Courage", "Bold" }, { "Afraid", "Scared" }, { "Aid", "Help" },
    { "Airplane", "Jet" }, { "Airplane", "Pilot" }, { "Ally", "Friend" }, { "Ancient", "Antique" },
    { "Angry", "Mad" }, { "Annotate", "Comment" }, { "Ant", "Bug" }, { "Anxious", "Nervous" },
    { "Appear", "Arrive" }, { "Arid", "Desert" }, { "Army", "Troops" }, { "Arrange", "Organize" },
    { "Artificial", "Fake" }, { "Artist", "Painter" }, { "Awake", "Alert" }, { "Awkward", "Clumsy" },
    { "Backpack", "Knapsack" }, { "Bag", "Sack" }, { "Bag", "Strap" }, { "Bark", "Growl" },
    { "Barren", "Empty" }, { "Battle", "Fight" }, { "Beach", "Sand" }, { "Beach", "Coast" },
    { "Bed", "Mattress" }, { "Pillow", "Blanket" }, { "Belief", "Faith" }, { "Belt", "Buckle" },
    { "Bicycle", "Motorcycle" }, { "Big", "Large" }, { "Bird", "Feather" }, { "Bitter", "Sour" },
    { "Bizarre", "Strange" }, { "Bland", "Taste" }, { "Blow", "Puff" }, { "Blunt", "Dull" },
    { "Boat", "Sail" }, { "Boil", "Simmer" }, { "Story", "Read" }, { "Poet", "Author" },
    { "Boring", "Tedious" }, { "Liqour", "Flask" }, { "Bounce", "Rebound" }, { "Box", "Cardboard" },
    { "Bracelet", "Wrist" }, { "Brave", "Fearless" }, { "Brave", "Bold" }, { "Fracture", "Shatter" },
    { "Breeze", "Wind" }, { "Tea", "Coffee" }, { "Brick", "Clay" }, { "Bridge", "Overpass" },
    { "Shine", "Glow" }, { "Bright", "Sunny" }, { "Injure", "Damage" }, { "Broth", "Soup" },
    { "Build", "Construct" }, { "Bumpy", "Rough" }, { "Buy", "Sell" }, { "Buzz", "Hum" },
    { "Tornado", "Twister" }, { "Calendar", "Date" }, { "Call", "Phone" }, { "Calm", "Relax" },
    { "Camera", "Photo" }, { "Canoe", "Kayak" }, { "Canyon", "Valley" }, { "Car", "Truck" },
    { "Carve", "Sculpt" }, { "Carpet", "Rug" }, { "Cash", "Money" }, { "Castle", "Fortress" },
    { "Catch", "Grab" }, { "Cave", "Grotto" }, { "Chair", "Seat" }, { "Chaos", "Order" },
    { "Charm", "Delight" }, { "Chirp", "Tweet" }, { "Chop", "Slice" }, { "City", "Town" },
    { "Clean", "Neat" }, { "Clear", "Transparent" }, { "Clever", "Wit" }, { "Cliff", "Edge" },
    { "Climb", "Ascend" }, { "Cut", "Trim" }, { "Clock", "Alarm" }, { "Closed", "Shut" },
    { "Clothes", "Closet" }, { "Cloud", "Fog" }, { "Cold", "Frozen" }, { "Collapse", "Crumble" },
    { "Computer", "Laptop" }, { "Conditioner", "Shampoo" }, { "Mystery", "Puzzle" }, 
    { "Conquer", "Defeat" }, { "Cook", "Bake" }, { "Cool", "Cold" }, { "Crack", "Split" },
    { "Barter", "Trade" }, { "Crawl", "Creep" }, { "Create", "Design" }, { "Crisp", "Crunchy" },
    { "Critic", "Judge" }, { "Cruise", "Glide" }, { "Cry", "Mourn" }, { "Cultivate", "Grow" },
    { "Cup", "Mug" }, { "Curtain", "Shutter" }, { "Damp", "Moist" }, { "Dance", "Sing" },
    { "Danger", "Risk" }, { "Dark", "Dim" }, { "Fast", "Quick" }, { "Defeat", "Loss" },
    { "Delicate", "Fragile" }, { "Destroy", "Break" }, { "Wreck", "Ruin" }, { "Dirt", "Mud" },
    { "Grease", "Grime" }, { "Blemish", "Smudge" }, { "Disappear", "Vanish" }, { "Hidden", "Subtle" },
    { "Disease", "Plague" }, { "Illusion", "Deceit" }, { "False", "True" }, { "Distract", "Deflect" },
    { "Dive", "Submerge" }, { "Dizzy", "Confused" }, { "Dog", "Cat" }, { "Collar", "Leash" },
    { "Doodle", "Scribble" }, { "Door", "Hatch" }, { "Draw", "Sketch" }, { "Dread", "Fear" },
    { "Drink", "Sip" }, { "Spill", "Leak" }, { "Drive", "Operate" }, { "Dry", "Arid" },
    { "Boring", "Bland" }, { "Dumb", "Stupid" }, { "Earth", "Ground" }, { "Easy", "Simple" },
    { "Eat", "Consume" }, { "Edit", "Improve" }, { "Teach", "Learn" }, { "Elder", "Senior" },
    { "Dodge", "Avoid" }, { "Available", "Vacant" }, { "Empty", "Hollow" }, { "End", "Finish" },
    { "Enemy", "Foe" }, { "Epic", "Legendary" }, { "Error", "Mistake" }, { "Espresso", "Coffee" },
    { "Excited", "Eager" }, { "Exit", "Entrance" }, { "Expensive", "Valuable" }, { "Pastel", "Pale" },
    { "Drip", "Drop" }, { "Famous", "Celebrity" }, { "Far", "Distant" }, { "Farm", "Crops" },
    { "Speed", "Rapid" }, { "Fertile", "Rich" }, { "Festival", "Carnival" }, { "Field", "Meadow" },
    { "Fierce", "Intense" }, { "Uncover", "Discover" }, { "Find", "Locate" }, { "Fire", "Flame" },
    { "Smog", "Smoke" }, { "Fish", "Aquarium" }, { "Fix", "Repair" }, { "Heal", "Mend" },
    { "Flag", "Banner" }, { "Fleece", "Shear" }, { "Adapt", "Flex" }, { "Flip", "Turn" },
    { "Floor", "Deck" }, { "Flow", "Stream" }, { "Flower", "Petal" }, { "Focus", "Center" },
    { "Fold", "Bend" }, { "Food", "Meal" }, { "Fool", "Jester" }, { "Forest", "Woods" },
    { "Rainforest", "Jungle" }, { "Forget", "Ignore" }, { "Silverware", "Utensil" }, { "Fork", "Spoon" },
    { "Unlucky", "Lucky" }, { "Fortune", "Wealth" }, { "Frame", "Outline" }, { "Free", "Available" },
    { "Freeze", "Chill" }, { "Crunch", "Crisp" }, { "Fresh", "New" }, { "Friend", "Ally" },
    { "Charm", "Charisma" }, { "Stuff", "Pack" }, { "Funny", "Comedy" }, { "Humor", "Wit" },
    { "Fuzzy", "Fluffy" }, { "Game", "Sport" }, { "Gaze", "Peer" }, { "Generous", "Charity" },
    { "Gentle", "Mild" }, { "Genuine", "Authentic" }, { "Gift", "Present" }, { "Give", "Offer" },
    { "Glasses", "Goggles" }, { "Glide", "Float" }, { "Gloomy", "Somber" }, { "Gloves", "Mittens" },
    { "Go", "Stop" }, { "Gold", "Silver" }, { "Finger", "Hand" }, { "Good", "Bad" },
    { "Government", "Kingdom" }, { "Respect", "Polite" }, { "Grim", "Serious" }, { "Grit", "Scruff" },
    { "Tactile", "Texture" }, { "Grow", "Expand" }, { "Grumpy", "Temper" }, { "Guide", "Escort" },
    { "Gush", "Surge" }, { "Handbag", "Purse" }, { "Billfold", "Wallet" }, { "Happy", "Joy" },
    { "Harbor", "Port" }, { "Solid", "Firm" }, { "Hard", "Tough" }, { "Harmony", "Melody" },
    { "Hat", "Cap" }, { "Healthy", "Fit" }, { "Heat", "Warm" }, { "Heavy", "Weight" },
    { "Large", "Massive" }, { "Helmet", "Hardhat" }, { "Support", "Assist" }, { "Hide", "Conceal" },
    { "High", "Tall" }, { "Highway", "Driveway" }, { "Hike", "Rugged" }, { "Hill", "Mound" },
    { "Hit", "Punch" }, { "Hoard", "Collect" }, { "Honest", "Truth" }, { "Horror", "Scary" },
    { "Hot", "Warm" }, { "House", "Home" }, { "Roof", "Ceiling" }, { "House", "Dwelling" },
    { "Howl", "Roar" }, { "Humble", "Modest" }, { "Hungry", "Starving" }, { "Drought", "Famine" },
    { "Rush", "Dash" }, { "Left", "Right" }, { "Imagine", "Dream" }, { "Innocent", "Guilty" },
    { "Insect", "Bug" }, { "Inspire", "Motivate" }, { "Intelligent", "Smart" }, { "Intricate", "Detailed" },
    { "Island", "Peninsula" }, { "Jacket", "Coat" }, { "Job", "Work" }, { "Trip", "Fall" },
    { "Journey", "Voyage" }, { "Juice", "Lemonade" }, { "Jump", "Hop" }, { "Leap", "Bound" },
    { "Keep", "Hold" }, { "Code", "Password" }, { "Key", "Lock" }, { "Kick", "Strike" },
    { "Kind", "Nice" }, { "Kingdom", "Empire" }, { "Knife", "Blade" }, { "Knit", "Stitch" },
    { "Lake", "Pond" }, { "Lamp", "Bulb" }, { "Large", "Huge" }, { "Late", "Delay" },
    { "Laugh", "Giggle" }, { "Law", "Rule" }, { "Lazy", "Idle" }, { "Leader", "Chief" },
    { "Lemon", "Lime" }, { "Letter", "Envelope" }, { "Liberty", "Freedom" }, { "Lift", "Hoist" },
    { "Light", "Bright" }, { "Listen", "Hear" }, { "Alone", "Isolated" }, { "Look", "Glance" },
    { "Loose", "Slack" }, { "Lose", "Fail" }, { "Loud", "Noise" }, { "Love", "Adore" },
    { "Low", "Short" }, { "Lush", "Thrive" }, { "Malicious", "Spite" }, { "Manager", "Boss" },
    { "Map", "Chart" }, { "Direction", "Compass" }, { "Margarine", "Butter" }, { "Marinate", "Soak" },
    { "Market", "Bazaar" }, { "Mash", "Crush" }, { "Meal", "Recipe" }, { "Mean", "Cruel" },
    { "Melt", "Dissolve" }, { "Meow", "Purr" }, { "Message", "Note" }, { "Chaos", "Disorder" },
    { "Messy", "Dirty" }, { "Metal", "Iron" }, { "Boulder", "Ore" }, { "Modern", "Contemporary" },
    { "Summit", "Peak" }, { "Mountain", "Valley" }, { "Movie", "Film" }, { "Producer", "Director" },
    { "Normal", "Ordinary" }, { "Music", "Song" }, { "Clue", "Hint" }, { "Naive", "Gullible" },
    { "Slim", "Thin" }, { "Nation", "Country" }, { "Natural", "Organic" }, { "Near", "Close" },
    { "Order", "Tidy" }, { "Necklace", "Chain" }, { "Necklace", "Amulet" }, { "Neglect", "Ignore" },
    { "Noble", "Honor" }, { "Book", "Novel" }, { "Obscure", "Unknown" }, { "Ocean", "Sea" },
    { "Age", "Time" }, { "Old", "Ancient" }, { "Opaque", "Obstructed" }, { "Open", "Unlocked" },
    { "Reveal", "Expose" }, { "Regular", "Common" }, { "Paint", "Color" }, { "Canvas", "Artwork" },
    { "Pants", "Shorts" }, { "Paper", "Sheet" }, { "Parade", "March" }, { "Pass", "Throw" },
    { "Path", "Trail" }, { "Tranquil", "Serene" }, { "Peer", "Gaze" }, { "Pen", "Marker" },
    { "Perfume", "Fragrance" }, { "Bottle", "Container" }, { "Pitcher", "Decanter" }, { "Endure", "Survive" },
    { "Phone", "Cell" }, { "Picture", "Image" }, { "Pillow", "Cushion" }, { "Hover", "Fly" },
    { "Plate", "Dish" }, { "Plateau", "Mesa" }, { "Play", "Fun" }, { "Pluck", "Gather" },
    { "Plump", "Chubby" }, { "Plunge", "Sink" }, { "Poem", "Verse" }, { "Polish", "Refine" },
    { "Poor", "Broke" }, { "Weight", "Heavy" }, { "Press", "Push" }, { "Pretend", "Act" },
    { "Prize", "Award" }, { "Proud", "Arrogant" }, { "Publish", "Release" }, { "Pull", "Tug" },
    { "Puncture", "Pierce" }, { "Punishment", "Penalty" }, { "Push", "Shove" }, { "Quake", "Tremor" },
    { "Fast", "Rapid" }, { "Quick", "Swift" }, { "Quick", "Fast" }, { "Mute", "Silent" },
    { "Quiet", "Whisper" }, { "Shine", "Bright" }, { "Drizzle", "Rain" }, { "Rare", "Scarce" },
    { "Learn", "Study" }, { "Regular", "Standard" }, { "Rely", "Depend" }, { "Remark", "Note" },
    { "Remember", "Recall" }, { "Repair", "Fix" }, { "Rich", "Wealth" }, { "Ride", "Mount" },
    { "Rigid", "Stiff" }, { "Ring", "Hoop" }, { "Rise", "Lift" }, { "River", "Stream" },
    { "Brook", "Creek" }, { "Roam", "Wander" }, { "Roast", "Grill" }, { "Rock", "Stone" },
    { "Tile", "Shingle" }, { "Rough", "Coarse" }, { "Jagged", "Bumpy" }, { "Rude", "Mean" },
    { "Dictator", "Monarch" }, { "Run", "Sprint" }, { "Rust", "Decay" }, { "Sad", "Sorrow" },
    { "Safe", "Secure" }, { "Guard", "Protect" }, { "Savage", "Primitive" }, { "Scamper", "Scurry" },
    { "Fright", "Scare" }, { "Scared", "Afraid" }, { "Scarf", "Shawl" }, { "Nape", "Neck" },
    { "Scatter", "Spread" }, { "Sculpt", "Chisel" }, { "Track", "Hunt" }, { "Search", "Seek" },
    { "Selfish", "Greed" }, { "Sell", "Trade" }, { "Retail", "Market" }, { "Stern", "Grave" },
    { "Drunk", "Sober" }, { "Serious", "Solemn" }, { "Shadow", "Shade" }, { "Shampoo", "Hair" },
    { "Shape", "Mold" }, { "Share", "Divide" }, { "Sharp", "Point" }, { "Shatter", "Fragment" },
    { "Shine", "Glow" }, { "Shingle", "Roof" }, { "Gloss", "Glaze" }, { "Ship", "Vessel" },
    { "Shirt", "Blouse" }, { "Choker", "Collar" }, { "Shoe", "Foot" }, { "Top", "Bottom" },
    { "Shop", "Store" }, { "Shore", "Coast" }, { "Concise", "Brief" }, { "Shout", "Yell" },
    { "Show", "Display" }, { "Shrink", "Reduce" }, { "Shy", "Quiet" }, { "Sick", "Ill" },
    { "Silent", "Mute" }, { "Silly", "Goofy" }, { "Silver", "Coin" }, { "Simple", "Basic" },
    { "Simple", "Plain" }, { "Sing", "Chant" }, { "Sit", "Rest" }, { "Sizzle", "Fry" },
    { "Staulk", "Skulk" }, { "Skill", "Ability" }, { "Prance", "Frolick" }, { "Sleek", "Smooth" },
    { "Sleep", "Doze" }, { "Slice", "Cut" }, { "Slow", "Steady" }, { "Small", "Tiny" },
    { "Smile", "Grin" }, { "Odd", "Even" }, { "Slippery", "Slick" }, { "Interest", "Curious" },
    { "Snow", "Ice" }, { "Soap", "Suds" }, { "Sock", "Stocking" }, { "Sock", "Shoe" },
    { "Soft", "Tender" }, { "Word", "Lyric" }, { "Want", "Desire" }, { "Sour", "Tart" },
    { "Discuss", "Talk" }, { "Speak", "Chat" }, { "Dialogue", "Conference" }, { "Sphere", "Ball" },
    { "Spice", "Zest" }, { "Spill", "Overflow" }, { "Spin", "Rotate" }, { "Spoon", "Ladle" },
    { "Sprinkle", "Dust" }, { "Lunge", "Dash" }, { "Sprout", "Bloom" }, { "Stab", "Impale" },
    { "Stack", "Layer" }, { "Stale", "Musty" }, { "Stand", "Rise" }, { "Steal", "Snatch" },
    { "Steam", "Boil" }, { "Stir", "Mix" }, { "Stop", "Halt" }, { "Storm", "Tempest" },
    { "Street", "Road" }, { "Strong", "Sturdy" }, { "Cement", "Concrete" }, { "Hearty", "Robust" },
    { "Stubborn", "Rigid" }, { "Student", "Pupil" }, { "Suit", "Tie" }, { "Suitcase", "Luggage" },
    { "Sun", "Star" }, { "Surf", "Wave" }, { "Sweet", "Sugar" }, { "Swim", "Dive" },
    { "Synthetic", "Artificial" }, { "Table", "Desk" }, { "Take", "Grab" }, { "Task", "Duty" },
    { "Yummy", "Delicious" }, { "Television", "Series" }, { "Clicker", "Remote" }, { "Temporary", "Interim" },
    { "Terrific", "Fantastic" }, { "Thick", "Dense" }, { "Think", "Consider" }, { "Thirst", "Parched" },
    { "Throw", "Toss" }, { "Thunder", "Lightning" }, { "Compress", "Compact" }, { "Timid", "Shy" },
    { "Tired", "Drowsy" }, { "Exhaust", "Fatigue" }, { "Tight", "Clench" }, { "Mouthwash", "Toothpaste" },
    { "Tower", "Skyscraper" }, { "Governor", "Mayor" }, { "Train", "Railroad" }, { "Tree", "Oak" },
    { "Tree", "Leaf" }, { "Trek", "Journey" }, { "Stroll", "Hike" }, { "Elegant", "Chic" },
    { "Trickle", "Drip" }, { "Trudge", "Slog" }, { "Trust", "Faith" }, { "Tunnel", "Passage" },
    { "Turbulence", "Frenzy" }, { "Shift", "Pivot" }, { "Tweak", "Adjust" }, { "Twiddle", "Fidget" },
    { "Twist", "Spiral" }, { "Ugly", "Hideous" }, { "Umbrella", "Parasol" }, { "Blight", "Scourge" },
    { "Unique", "Distinct" }, { "Unravel", "Decipher" }, { "Vast", "Expanse" }, { "Vehicle", "Transport" },
    { "Vibrant", "Bright" }, { "Vibrate", "Tremble" }, { "Victory", "Triumph" }, { "Village", "Settlement" },
    { "Wait", "Pause" }, { "Wallet", "Billfold" }, { "War", "Conflict" }, { "Warrior", "Soldier" },
    { "Caution", "Wary" }, { "Watch", "Observe" }, { "Water", "Wet" }, { "Weak", "Fragile" },
    { "Opulent", "Lavish" }, { "Weave", "Intertwine" }, { "Mush", "Soggy" }, { "Whale", "Shark" },
    { "Whisk", "Beat" }, { "Whisper", "Murmur" }, { "Whittle", "Carve" }, { "Wide", "Broad" },
    { "Win", "Earn" }, { "Window", "Glass" }, { "Wisdom", "Knowledge" }, { "Wise", "Smart" },
    { "Write", "Scribble" }, { "Writer", "Author" }, { "Yank", "Pull" }, { "Young", "Youth" },
    { "Booth", "Stall" }, { "Wreath", "Garland" }, { "Scar", "Birthmark" }, { "Token", "Coupon" },
    { "Emblem", "Badge" }, { "Factory", "Mill" } };

    public TMP_Text topWord, bottomWord;
    public Image targetImage;    // Assign your image in the Inspector
    public float sizeMultiplier = 1.5f;   // How much bigger the image should get
    public float pulseDuration = 0.5f;  // How long the image is large
    private Vector3 originalSize;  // Stores the original size of the image

    AudioManager audioManager;

    private void Awake()
    {
        audioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManager>();
    }

    void Start()
    {
        if (targetImage == null)
        {
            targetImage = GetComponent<Image>();
        }

        originalSize = targetImage.transform.localScale;
    }

    void generatePair()
    {
        //Randomly select a word pair from the bank
        int x = (int)Random.Range(0, wordBank.GetLength(0)-1);
        string[] cardPair = { wordBank[x,0], wordBank[x,1]};


        //Display card after randomly assigning the card orientation
        if (Random.Range(0,1) == 1)
        {
            topWord.text = cardPair[0].ToLower();
            bottomWord.text = cardPair[1].ToLower();

        } else
        {
            topWord.text = cardPair[1].ToLower();
            bottomWord.text = cardPair[0].ToLower();
        }

    }
   
    public void PulseImage()
    {
        StartCoroutine(PulseRoutine());
    }

    private IEnumerator PulseRoutine()
    {
        targetImage.transform.localScale = originalSize * sizeMultiplier; // Scale up the image
        yield return new WaitForSeconds(pulseDuration); // Wait for the duration of the pulse
        targetImage.transform.localScale = originalSize; // Scale the image back to its original size
    }


    public void OnCardDraw()
    {
        print(wordBank.GetLength(0)*2);
        audioManager.PlaySFX(audioManager.cardDraw);
        generatePair();
        PulseImage();
    }

}
