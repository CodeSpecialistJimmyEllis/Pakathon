/*

#region Using Statements
using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Storage;
using Microsoft.Xna.Framework.GamerServices;
#endregion

namespace JESUSISLORDplatformer
{
    /// <summary>
    /// This is the main type for your game
    /// </summary>
    public class TextEngine
    {

        bool[] wasletterused;
        int[] spacingsize1;
        //character used to convert string to int
        char[] characters;
        //enumerations to keep up with the alphabet letter used
        enum Alphabet : int
        {
            a = 0, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p, q, r, s, t, u, v, w, x, y, z
        };

        // enum for multi constructor polymorphic technique
        enum Constructor : int
        {
            one, two, three
        };

        Constructor chosen;
        bool[] used;
        bool used2 = false;
        //graphics array full of each 0 to 25 properly named default xnafast fonts 
        Texture2D[] alphabettextures;
        Rectangle[] alphabetrect;

        //allows letters to reppeat

        int[] repeatindex;
        bool[] fiveletterrepeat;

        //theactualsizeof the word
        int sizeofword = 3;
        // array of strings to load textures;
        string[] alphabetnumbers;

        //  constructors. one sets alphabet height and size and starting point | the other sets starting and ending point and chooses size based on algorithim. one just passes text and creates one at the default position on screen and things happen based on time.
        int alphabetwidth;
        int alphabetheight;
        Vector2 startingpoint;
        Vector2 endingpoint;

        //TODO: THIS PUTS CHARACTERS ON THE SCREEN WHERE YOU WANT THEM TO BE ""THE KUNG FU MAN"" AND THEN THEY ARE HANDLED BY CHARACTER CLASSES THIS WILL TAKE UP THREE MORE CONSTRUCTORS 

        int wordused;
        int wordspace;
        // variable to calculate space for constructors 
        int defaultspaceconstructor3;
        int calculatedspace;

        string text;
        Texture2D backgroundSpace;
        Rectangle backgroundspacelocation;

       
        public TextEngine(string newtext, int newsizeofword)
        {
            this.text = newtext;
            chosen = Constructor.one;
            this.sizeofword = newsizeofword;
           spacingsize1 = new int[] { 50, 105, 160, 210, 265, 320, 375, 430, 485, 540, 595, 650, 705, 760, 815, 870, 925, 980, 1035, 1090, 1145, 1200, 1255, 1310, 1365, 1420 };
     alphabetwidth = 64;
           alphabetheight = 64;
            //

         
           wordused = 0;
           wordspace = 50;
            //spacing array between letters at certain sizes
            // int[] spacingsize = new int[5];


            // TODO: Add your initialization logic here
            //this code sets up all texture arrays by inintating them
            alphabettextures = new Texture2D[26];
            //this code initializes all an array of strings
            alphabetnumbers = new string[26];

            repeatindex = new int[26];
            for (int j = 0; j < 26; ++j)
            {
                repeatindex[j] = 1;
            }



            alphabetrect = new Rectangle[26];

            for (int z = 0; z < 26; ++z)
            {
                alphabetrect = new Rectangle[z];
            }


            //set was letter used to false 
            wasletterused = new bool[26];

            for (int m = 0; m < 26; m++)
            {
                wasletterused[m] = false;

            }
            used = new bool[26];

            for (int q = 0; q < 26; q++)
            {
                used[q] = false;

            }

            // character intialization for string to character conversion
            characters = new char[sizeofword];
            // int i = 0;
            for (int a = 0; a < 26; ++a)
            {
                alphabettextures = new Texture2D[a];
            }




            // this for statemenet sets up the string alphabet numbers so that it can be used in place of a string to load textures 
            for (int i = 0; i < 26; ++i)
            {
                alphabetnumbers[i] = i.ToString();
                i++;
            }





            // PHEONOMINA 
            // sets vectors for starting and ending point

            //startingpoint = new Vector2(0, 0);
            //endingpoint = new Vector2()
        
        }

        public TextEngine(string newtext, int newsizeofword, Vector2 newstartingpoint )
        {
            this.text = newtext;
            chosen = Constructor.one;
            this.sizeofword = newsizeofword;
            this.startingpoint = newstartingpoint;
            spacingsize1 = new int[] { 50, 105, 160, 210, 265, 320, 375, 430, 485, 540, 595, 650, 705, 760, 815, 870, 925, 980, 1035, 1090, 1145, 1200, 1255, 1310, 1365, 1420 };
      
            //
            alphabetwidth = 64;
            alphabetheight = 64;

         wordused = 0;
           wordspace = 50;
            //spacing array between letters at certain sizes
            // int[] spacingsize = new int[5];


            // TODO: Add your initialization logic here
            //this code sets up all texture arrays by inintating them
            alphabettextures = new Texture2D[26];
            //this code initializes all an array of strings
            alphabetnumbers = new string[26];

            repeatindex = new int[26];
            for (int j = 0; j < 26; ++j)
            {
                repeatindex[j] = 1;
            }



            alphabetrect = new Rectangle[26];

         //   for (int z = 0; z < 26; z++)
           // {
            //    alphabetrect = new Rectangle[z];
           // }


            //set was letter used to false 
            wasletterused = new bool[26];

            for (int m = 0; m < 26; m++)
            {
                wasletterused[m] = false;

            }
            used = new bool[26];

            for (int q = 0; q < 26; q++)
            {
                used[q] = false;

            }

            // character intialization for string to character conversion
            characters = new char[sizeofword];
            // int i = 0;
          //  for (int a = 0; a < 26; a++)
           // {
            //    alphabettextures = new Texture2D[a];
          //  }




            // this for statemenet sets up the string alphabet numbers so that it can be used in place of a string to load textures 
            for (int i = 0; i < 26; ++i)
            {
                alphabetnumbers[i] = i.ToString();
                i++;
            }





            // PHEONOMINA 
            // sets vectors for starting and ending point

           // startingpoint = new Vector2(0, 0);
            //endingpoint = new Vector2()
        
        }

        /*
        public TextEngine(string newtext,int newsizeofword, int newalphabetwidth, int newalphabetheight, Vector2 newstartingpoint)
        {
            this.alphabetheight = newalphabetheight;
            this.alphabetwidth = newalphabetwidth;
            this.startingpoint = newstartingpoint;
            this.text = newtext;
            chosen = Constructor.three;
          this.sizeofword = newsizeofword;
        }

        public TextEngine(string newtext,int newsizeofword, Vector2 newstartingpoint, Vector2 endingpoint)
        {
         * 
            // y must stay the same in starting and ending point 
            this.startingpoint = newstartingpoint;
            this.endingpoint = newendingpoint; 
            this.text = newtext;
            chosen = Constructor.one;
          this.sizeofword = newsizeofword;
        }
        */
    
   

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        /// /*
        /// 

/*
       public void Initialize()
        {

        }

        //CONSTRUCTOR 1 CALCULATION METHOD for height, width, and startingpoint and text

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        public void LoadContent(ContentManager Content)
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            

            Alphabet count;
            #region LoadingTextures In Array
            for (int c = 0; c < 26; c++)
            {

                count = (Alphabet)c;
                if (count == Alphabet.a)
                {
                    alphabettextures[c] = Content.Load<Texture2D>("xnafastdefaultfont/0");
                }

                else if (count == Alphabet.b)
                {
                    alphabettextures[c] = Content.Load<Texture2D>("xnafastdefaultfont/1");
                }

                else if (count == Alphabet.c)
                {
                    alphabettextures[c] = Content.Load<Texture2D>("xnafastdefaultfont/2");
                }

                 else if (count == Alphabet.d)
                {
                    alphabettextures[c] = Content.Load<Texture2D>("xnafastdefaultfont/3");
                }

                else if (count == Alphabet.e)
                {
                    alphabettextures[c] = Content.Load<Texture2D>("xnafastdefaultfont/4");
                }

                else if (count == Alphabet.f)
                {
                    alphabettextures[c] = Content.Load<Texture2D>("xnafastdefaultfont/5");
                }

                else if (count == Alphabet.g)
                {
                    alphabettextures[c] = Content.Load<Texture2D>("xnafastdefaultfont/6");
                }

                else if (count == Alphabet.h)
                {
                    alphabettextures[c] = Content.Load<Texture2D>("xnafastdefaultfont/7");
                }


                else if (count == Alphabet.i)
                {
                    alphabettextures[c] = Content.Load<Texture2D>("xnafastdefaultfont/8");
                }


                else if (count == Alphabet.j)
                {
                    alphabettextures[c] = Content.Load<Texture2D>("xnafastdefaultfont/9");
                }


                else if (count == Alphabet.k)
                {
                    alphabettextures[c] = Content.Load<Texture2D>("xnafastdefaultfont/10");
                }

                else if (count == Alphabet.l)
                {
                    alphabettextures[c] = Content.Load<Texture2D>("xnafastdefaultfont/11");
                }


                else if (count == Alphabet.m)
                {
                    alphabettextures[c] = Content.Load<Texture2D>("xnafastdefaultfont/12");
                }


                else if (count == Alphabet.n)
                {
                    alphabettextures[c] = Content.Load<Texture2D>("xnafastdefaultfont/13");
                }


                else if (count == Alphabet.o)
                {
                    alphabettextures[c] = Content.Load<Texture2D>("xnafastdefaultfont/14");
                }


                else if (count == Alphabet.p)
                {
                    alphabettextures[c] = Content.Load<Texture2D>("xnafastdefaultfont/15");
                }



                else if (count == Alphabet.q)
                {
                    alphabettextures[c] = Content.Load<Texture2D>("xnafastdefaultfont/16");
                }


                else if (count == Alphabet.r)
                {
                    alphabettextures[c] = Content.Load<Texture2D>("xnafastdefaultfont/17");

                }

                else if (count == Alphabet.s)
                {
                    alphabettextures[c] = Content.Load<Texture2D>("xnafastdefaultfont/18");
                }

                else if (count == Alphabet.t)
                {
                    alphabettextures[c] = Content.Load<Texture2D>("xnafastdefaultfont/19");
                }

                else if (count == Alphabet.u)
                {
                    alphabettextures[c] = Content.Load<Texture2D>("xnafastdefaultfont/20");
                }

                else if (count == Alphabet.v)
                {
                    alphabettextures[c] = Content.Load<Texture2D>("xnafastdefaultfont/21");
                }

                else if (count == Alphabet.w)
                {
                    alphabettextures[c] = Content.Load<Texture2D>("xnafastdefaultfont/22");
                }

                else if (count == Alphabet.x)
                {
                    alphabettextures[c] = Content.Load<Texture2D>("xnafastdefaultfont/23");
                }

                else if (count == Alphabet.y)
                {
                    alphabettextures[c] = Content.Load<Texture2D>("xnafastdefaultfont/24");
                }

                else  if (count == Alphabet.z)
                {
                    alphabettextures[c] = Content.Load<Texture2D>("xnafastdefaultfont/25");
                }

            #endregion



                #region Constructor1 Tasks


                if (Constructor.one == chosen)
                {

                    for (int y = 0; y < 26; y++)
                    {
                        alphabetrect[y] = new Rectangle((int)startingpoint.X, (int)startingpoint.Y, alphabetwidth, alphabetheight);

                    }
                    // characters = text.ToCharArray();





                }


                if (Constructor.two == chosen)
                {

                    //  alphabetrect = new Rectangle((int)startingpoint.X, (int)startingpoint.Y, alphabetwidth, alphabetheight);
                }

                if (Constructor.three == chosen)
                {

                    //  alphabetrect = new Rectangle((int)startingpoint.X, (int)startingpoint.Y, alphabetwidth, alphabetheight);
                }
                #endregion

            }
            // TODO: use this.Content to load your game content here
        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// all content.
        /// </summary>
        public void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        public void Update(GameTime gameTime)
        {
      

            // TODO: Add your update logic here

      
        }


       public void Draw(SpriteBatch spriteBatch)
        {
          

           
            // TODO: Add your drawing code here
            if (Constructor.one == chosen)
            {
                characters = this.text.ToCharArray();
                int e = 0;


                #region LetterWritingAlgorithim
                for (int f = 0; f < sizeofword; f++)
                {
                    for (int g = 0; g < 26; g++)
                    {



                        if (characters[f] == 'a')
                        {



                            if (wasletterused[0] == true)
                            {


                                if (wordused != 26 && wordused < 26)
                                {
                                    wordused = wordused + 1;
                                }
                                else if (wordused == 26 || wordused > 25)
                                {
                                    wordused = 0;
                                }
                                else
                                {
                                    wordused = 0;
                                }
                                
                               
                                alphabetrect[0].X = alphabetrect[0].X + spacingsize1[wordused];
                                
                                used[0] = true;
                                wasletterused[0] = false;
                            }

                            if (used[0] == false)
                            {

                                if (wordused != 26 && wordused < 26)
                                {
                                    wordused = 0;
                                }
                                else
                                {
                                    wordused = 0;
                                }
                                
                                alphabetrect[0].X = alphabetrect[0].X + spacingsize1[wordused];
                            
                                used[0] = true;
                            }

                            spriteBatch.Draw(alphabettextures[0], alphabetrect[0], Color.White);

                            wasletterused[0] = true;
                        }
                        else if (characters[f] == 'b')
                        {


                            if (used2 == false)
                            {

                                if (wordused != 26 && wordused < 26)
                                {
                                    wordused = wordused + 1;
                                }
                                else if (wordused == 26 || wordused > 25)
                                {
                                    wordused = 0;
                                }
                                else
                                {
                                    wordused = 0;
                                }
                                
                                alphabetrect[1].X = alphabetrect[1].X + spacingsize1[wordused];
                                used2 = true;
                            }
                            spriteBatch.Draw(alphabettextures[1], alphabetrect[1], Color.White);
                        }
                        else if (characters[f] == 'c')
                        {


                            if (used[2] == false)
                            {

                                if (wordused != 26 && wordused < 26)
                                {
                                    wordused = wordused + 1;
                                }
                                else if (wordused == 26 || wordused > 25)
                                {
                                    wordused = 0;
                                }
                                else
                                {
                                    wordused = 0;
                                }
                                
                                alphabetrect[2].X += spacingsize1[wordused];
                                used[2] = true;
                            }
                            spriteBatch.Draw(alphabettextures[2], alphabetrect[2], Color.White);
                        }
                        else if (characters[f] == 'd')
                        {


                            if (used[3] == false)
                            {

                                if (wordused != 26 && wordused < 26)
                                {
                                    wordused = wordused + 1;
                                }
                                else if (wordused == 26 || wordused > 25)
                                {
                                    wordused = 0;
                                }
                                else
                                {
                                    wordused = 0;
                                }
                                
                                alphabetrect[3].X += spacingsize1[wordused];
                                used[3] = true;
                            }
                            spriteBatch.Draw(alphabettextures[3], alphabetrect[3], Color.White);
                        }
                        else if (characters[f] == 'e')
                        {


                            if (used[4] == false)
                            {

                                if (wordused != 26 && wordused < 26)
                                {
                                    wordused = wordused + 1;
                                }
                                else if (wordused == 26 || wordused > 25)
                                {
                                    wordused = 0;
                                }
                                else
                                {
                                    wordused = 0;
                                }
                                
                                alphabetrect[4].X += spacingsize1[wordused];
                                used[4] = true;
                            }
                            spriteBatch.Draw(alphabettextures[4], alphabetrect[4], Color.White);
                        }
                        else if (characters[f] == 'f')
                        {


                            if (used[5] == false)
                            {

                                if (wordused != 26 && wordused < 26)
                                {
                                    wordused = wordused + 1;
                                }
                                else if (wordused == 26 || wordused > 25)
                                {
                                    wordused = 0;
                                }
                                else
                                {
                                    wordused = 0;
                                }
                                
                                alphabetrect[5].X += spacingsize1[wordused];
                                used[5] = true;
                            }
                            spriteBatch.Draw(alphabettextures[5], alphabetrect[5], Color.White);
                        }

                        else if (characters[f] == 'g')
                        {
                            if (used[6] == false)
                            {

                                if (wordused != 26 && wordused < 26)
                                {
                                    wordused = wordused + 1;
                                }
                                else if (wordused == 26 || wordused > 25)
                                {
                                    wordused = 0;
                                }
                                else
                                {
                                    wordused = 0;
                                }
                                
                                alphabetrect[6].X += spacingsize1[wordused];
                                used[6] = true;
                            }
                            spriteBatch.Draw(alphabettextures[6], alphabetrect[6], Color.White);
                        }

                        else if (characters[f] == 'h')
                        {
                            if (used[7] == false)
                            {

                                if (wordused != 26 && wordused < 26)
                                {
                                    wordused = wordused + 1;
                                }
                                else if (wordused == 26 || wordused > 25)
                                {
                                    wordused = 0;
                                }
                                else
                                {
                                    wordused = 0;
                                }
                                
                                alphabetrect[7].X += spacingsize1[wordused];
                                used[7] = true;
                            }
                            spriteBatch.Draw(alphabettextures[7], alphabetrect[7], Color.White);
                        }
                        else if (characters[f] == 'i')
                        {
                            if (used[8] == false)
                            {

                                if (wordused != 26 && wordused < 26)
                                {
                                    wordused = wordused + 1;
                                }
                                else if (wordused == 26 || wordused > 25)
                                {
                                    wordused = 0;
                                }
                                else
                                {
                                    wordused = 0;
                                }
                                
                                alphabetrect[8].X += spacingsize1[wordused];
                                used[8] = true;
                            }

                            spriteBatch.Draw(alphabettextures[8], alphabetrect[8], Color.White);
                        }
                        else if (characters[f] == 'j')
                        {
                            if (used[9] == false)
                            {

                                if (wordused != 26 && wordused < 26)
                                {
                                    wordused = wordused + 1;
                                }
                                else if (wordused == 26 || wordused > 25)
                                {
                                    wordused = 0;
                                }
                                else
                                {
                                    wordused = 0;
                                }
                                
                                alphabetrect[9].X += spacingsize1[wordused];
                                used[9] = true;
                            }


                            spriteBatch.Draw(alphabettextures[9], alphabetrect[9], Color.White);
                        }
                        else if (characters[f] == 'k')
                        {
                            if (used[10] == false)
                            {

                                if (wordused != 26 && wordused < 26)
                                {
                                    wordused = wordused + 1;
                                }
                                else if (wordused == 26 || wordused > 25)
                                {
                                    wordused = 0;
                                }
                                else
                                {
                                    wordused = 0;
                                }
                                
                                alphabetrect[10].X += spacingsize1[wordused];
                                used[10] = true;
                            }


                            spriteBatch.Draw(alphabettextures[10], alphabetrect[10], Color.White);
                        }
                        else if (characters[f] == 'l')
                        {
                            if (used[11] == false)
                            {

                                if (wordused != 26 && wordused < 26)
                                {
                                    wordused = wordused + 1;
                                }
                                else if (wordused == 26 || wordused > 25)
                                {
                                    wordused = 0;
                                }
                                else
                                {
                                    wordused = 0;
                                }
                                
                                alphabetrect[11].X += spacingsize1[wordused];
                                used[11] = true;
                            }

                            spriteBatch.Draw(alphabettextures[11], alphabetrect[11], Color.White);
                        }
                        else if (characters[f] == 'm')
                        {
                            if (used[12] == false)
                            {

                                if (wordused != 26 && wordused < 26)
                                {
                                    wordused = wordused + 1;
                                }
                                else if (wordused == 26 || wordused > 25)
                                {
                                    wordused = 0;
                                }
                                else
                                {
                                    wordused = 0;
                                }
                                
                                alphabetrect[12].X += spacingsize1[wordused];
                                used[12] = true;
                            }

                            spriteBatch.Draw(alphabettextures[12], alphabetrect[12], Color.White);
                        }
                        else if (characters[f] == 'n')
                        {
                            if (used[13] == false)
                            {

                                if (wordused != 26 && wordused < 26)
                                {
                                    wordused = wordused + 1;
                                }
                                else if (wordused == 26 || wordused > 25)
                                {
                                    wordused = 0;
                                }
                                else
                                {
                                    wordused = 0;
                                }
                                
                                alphabetrect[13].X += spacingsize1[wordused];
                                used[13] = true;
                            }

                            spriteBatch.Draw(alphabettextures[13], alphabetrect[13], Color.White);
                        }
                        else if (characters[f] == 'o')
                        {

                            if (used[14] == false)
                            {

                                if (wordused != 26 && wordused < 26)
                                {
                                    wordused = wordused + 1;
                                }
                                else if (wordused == 26 || wordused > 25)
                                {
                                    wordused = 0;
                                }
                                else
                                {
                                    wordused = 0;
                                }
                                
                                alphabetrect[14].X += spacingsize1[wordused];
                                used[14] = true;
                            }

                            spriteBatch.Draw(alphabettextures[14], alphabetrect[14], Color.White);
                        }
                        else if (characters[f] == 'p')
                        {
                            if (used[15] == false)
                            {

                                if (wordused != 26 && wordused < 26)
                                {
                                    wordused = wordused + 1;
                                }
                                else if (wordused == 26 || wordused > 25)
                                {
                                    wordused = 0;
                                }
                                else
                                {
                                    wordused = 0;
                                }
                                
                                alphabetrect[15].X += spacingsize1[wordused];
                                used[15] = true;
                            }


                            spriteBatch.Draw(alphabettextures[15], alphabetrect[15], Color.White);
                        }
                        else if (characters[f] == 'q')
                        {
                            if (used[16] == false)
                            {

                                if (wordused != 26 && wordused < 26)
                                {
                                    wordused = wordused + 1;
                                }
                                else if (wordused == 26 || wordused > 25)
                                {
                                    wordused = 0;
                                }
                                else
                                {
                                    wordused = 0;
                                }
                                
                                alphabetrect[16].X += spacingsize1[wordused];
                                used[16] = true;
                            }


                            spriteBatch.Draw(alphabettextures[16], alphabetrect[16], Color.White);
                        }
                        else if (characters[f] == 'r')
                        {
                            if (used[17] == false)
                            {

                                if (wordused != 26 && wordused < 26)
                                {
                                    wordused = wordused + 1;
                                }
                                else if (wordused == 26 || wordused > 25)
                                {
                                    wordused = 0;
                                }
                                else
                                {
                                    wordused = 0;
                                }
                                
                                alphabetrect[17].X += spacingsize1[wordused];
                                used[17] = true;
                            }

                            spriteBatch.Draw(alphabettextures[17], alphabetrect[17], Color.White);
                        }

                        #region Deep S Algorithim
                        else if (characters[f] == 's')
                        {
                            if (wasletterused[18] == true)
                            {

                                if (wordused != 26 && wordused < 26)
                                {
                                    repeatindex[18] = wordused + 1;
                                }
                                else if (wordused == 26 || wordused > 25)
                                {
                                    wordused = 0;
                                }
                                else
                                {
                                    wordused = 0;
                                }
                                
                                spriteBatch.Draw(alphabettextures[18], new Rectangle(spacingsize1[repeatindex[18]], alphabetrect[18].Y, 64, 64), Color.White);

                            }
                            if (used[18] == false)
                            {
                                if (wordused != 26 && wordused < 26)
                                {
                                    wordused = wordused + 1;
                                }
                                else if (wordused == 26 || wordused > 25)
                                {
                                    wordused = 0;
                                }
                                else
                                {
                                    wordused = 0;
                                }
                                
                                alphabetrect[18].X += spacingsize1[wordused];
                                used[18] = true;
                                wasletterused[18] = true;

                            }

                            spriteBatch.Draw(alphabettextures[18], alphabetrect[18], Color.White);
                        }

                        #endregion
                        else if (characters[f] == 't')
                        {
                            if (used[19] == false)
                            {

                                if (wordused != 26 && wordused < 26)
                                {
                                    wordused = wordused + 1;
                                }
                                else if (wordused == 26 || wordused > 25)
                                {
                                    wordused = 0;
                                }
                                else
                                {
                                    wordused = 0;
                                }
                                
                                alphabetrect[19].X += spacingsize1[wordused];
                                used[19] = true;
                            }


                            spriteBatch.Draw(alphabettextures[19], alphabetrect[19], Color.White);
                        }
                        else if (characters[f] == 'u')
                        {
                            if (used[20] == false)
                            {

                                if (wordused != 26 && wordused < 26)
                                {
                                    wordused = wordused + 1;
                                }
                                else if (wordused == 26 || wordused > 25)
                                {
                                    wordused = 0;
                                }
                                else
                                {
                                    wordused = 0;
                                }
                                
                                alphabetrect[20].X += spacingsize1[wordused];
                                used[20] = true;
                            }


                            spriteBatch.Draw(alphabettextures[20], alphabetrect[20], Color.White);
                        }
                        else if (characters[f] == 'v')
                        {
                            if (used[21] == false)
                            {

                                if (wordused != 26 && wordused < 26)
                                {
                                    wordused = wordused + 1;
                                }
                                else if (wordused == 26 || wordused > 25)
                                {
                                    wordused = 0;
                                }
                                else
                                {
                                    wordused = 0;
                                }
                                
                                alphabetrect[21].X += spacingsize1[wordused];
                                used[21] = true;
                            }


                            spriteBatch.Draw(alphabettextures[21], alphabetrect[21], Color.White);
                        }
                        else if (characters[f] == 'w')
                        {
                            if (used[22] == false)
                            {

                                if (wordused != 26 && wordused < 26)
                                {
                                    wordused = wordused + 1;
                                }
                                else if (wordused == 26 || wordused > 25)
                                {
                                    wordused = 0;
                                }
                                else
                                {
                                    wordused = 0;
                                }
                                
                                alphabetrect[22].X += spacingsize1[wordused];
                                used[22] = true;
                            }


                            spriteBatch.Draw(alphabettextures[22], alphabetrect[22], Color.White);
                        }
                        else if (characters[f] == 'x')
                        {
                            if (used[23] == false)
                            {

                                if (wordused != 26 && wordused < 26)
                                {
                                    wordused = wordused + 1;
                                }
                                else if (wordused == 26 || wordused > 25)
                                {
                                    wordused = 0;
                                }
                                else
                                {
                                    wordused = 0;
                                }
                                
                                alphabetrect[23].X += spacingsize1[wordused];
                                used[23] = true;
                            }


                            spriteBatch.Draw(alphabettextures[23], alphabetrect[23], Color.White);
                        }
                        else if (characters[f] == 'y')
                        {
                            if (used[24] == false)
                            {

                                if (wordused != 26 && wordused < 26)
                                {
                                    wordused = wordused + 1;
                                }
                                else if (wordused == 26 || wordused > 25)
                                {
                                    wordused = 0;
                                }
                                else
                                {
                                    wordused = 0;
                                }
                                
                                alphabetrect[24].X += spacingsize1[wordused];
                                used[24] = true;
                            }

                            spriteBatch.Draw(alphabettextures[24], alphabetrect[24], Color.White);
                        }
                        else if (characters[f] == 'z')
                        {
                            if (used[25] == false)
                            {

                                 if (wordused != 26 && wordused < 26)
                                {
                                    wordused = wordused + 1;
                                }
                                else if (wordused == 26 || wordused > 25)
                                {
                                    wordused = 0;
                                }
                                else
                                {
                                    wordused = 0;
                                }
                                
                                alphabetrect[25].X += spacingsize1[wordused];
                                used[25] = true;
                            }

                            spriteBatch.Draw(alphabettextures[25], alphabetrect[25], Color.White);
                        }
                    }
                }

                #endregion


             




                //    spriteBatch.Begin();
                //   spriteBatch.Draw(, backgroundRect, Color.White);
                //   spriteBatch.End();

            }



        }
    }
}
*/