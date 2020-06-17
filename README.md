<div dir="rtl">
   
# Monopoly3D מונופול

   
קישור לitch:

https://shakedshiran.itch.io/monopoly3d




## תיאור סקריפטים:



  
[Asset_tile](https://github.com/shakedsh/Monopoly/blob/master/Asset_tile.cs)
&#x202b;
זהו הסקריפט היחיד שהוא לא MonoBehaviour, הוא לא מקושר לאף אובייקט במשחק וזאת משום שהוא מהווה עצם של אריח שמכיל פרטים כגון: מיקום האריח, שמו, לאיזו קבוצה הוא משתייך, מה מחיר הקנייה שלו ועוד..
בסקריפט זה יש רק פעולות בונות וSET וGET.
      

  
  
[AllAssets_Tiles](https://github.com/shakedsh/Monopoly/blob/master/AllAssets_Tiles.cs)

סקריפט זה מכיל לנו את הרשימה של האריחים במשחק.
הוא מקושר לאובייקט worldObjects/streetTiles/tiles (ראה תמונה)
יש חשיבות לסדר האריחים בtiles וחשוב שלא יהיו בה פריטים שהם לא אחד מ28 (0-27) האריחים.
בסקריפט זה אנו מייצרים את העצמים של הAsset_tile (הסקריפט הקודם) ומכניסים אותם לרשימה.
את המיקומים הכנסתי בלולאת for שעוברת אחד אחד על כל הילדים של tiles (בצד שמאל בתמונה.



[Bank_Script](https://github.com/shakedsh/Monopoly/blob/master/Bank_Script.cs)

מקושר לCanvas/bank - עוד לא בשימוש.



[Dice_script](https://github.com/shakedsh/Monopoly/blob/master/Dice_script.cs)

מקושר לgameObjects/Dice
נקרא בעבר cube.
הפיתרון לבעיית הקובייה שמזהה עצירה לא מוחלטת הוא 2 בדיקות של המיקום. ברגע שמזוהה עצירה שומרים את מיקום העצירה, ופונים לבדיקה נוספת (המשתנה isStopCheck חיובי כאשר אנו נכנסים לבדיקה השניה ולא מאפשר להיכנס לבדיקה הראשונה בזמן הזה. בבדיקה השנייה אנו מחכים שניה ואז בודקים את המיקום הנוכחי ביחס למיקום ששמרנו בבדיקה הראשונה אם הם זהים יש עצירה אם לא משנים את isStopCheck  לשלילי וממשיכים הלאה.


[LevelController](https://github.com/shakedsh/Monopoly/blob/master/LevelController.cs)

סקריפט שמיועד עבור כפתור להחליף סצנות.
טרם החלטנו האם לבצע מספר סצנות במשחק מפני שאת הוראות המשחק ניתן לכתוב בסצנה הראשית ושאפשר יהיה להיכנס לפאנל זה בכל פעם

[Player_Movement](https://github.com/shakedsh/Monopoly/blob/master/Player_Movement.cs)

מקושר לgameObjects/players/MyPlayer

המשתנה החשוב פה הוא playerSituation, הוא שווה 1- בתחילת המשחק, 1 אם השחקן צריך לזוז ו0 אם הוא כבר זז.
אם הוא 1 (צריך לזוז) ואם המיקום של השחקן על ציר הX (בינתיים) גדול (כאן זה הפוך מההיגיון) מהמיקום של האריח שצריך להגיע אליו (עושים זאת ע"י לקיחת האריח במקום ה[תוצאה שיצאה בקוביה+ המקום הנוכחי שלנו] מתוך רשימת האריחים)
אז תזיז את השחקן.
אחרת הגענו למקום ואנחנו קוראים לפונקציה CurrentTileUpdate שנמצאת למטה ומעדכנת את הסקריפטים  שעוד לא דיברנו עליהם.


[PlayerAccount](https://github.com/shakedsh/Monopoly/blob/master/PlayerAccount.cs)

מקושר גם לgameObjects/players/MyPlayer
מהווה עצם לחשבון הלקוח, כשניצור שחקנים חדשים ניצור אותם דרכו.
מכיל את שם השחקן, הכסף שלו ורשימת הנכסים שלו.

עשוי בעיקר מפעולות SET וGET.


[PanelOpener](https://github.com/shakedsh/Monopoly/blob/master/PanelOpener.cs)


סקריפט שפותח פאנל (מסך חצי שקוף).
הסקריפט הזה מקושר לCanvas/bank/BankBTN , לכפתור של הבנק.


ע"י פתיחת הפאנל שמסומן בכחול בתמונה הוא מאפשר לצפות ברכוש שלך (כסף+נכסים) ובהמשך גם בשל השחקנים האחרים.


[PanelOpener_IfPlayerStanding](https://github.com/shakedsh/Monopoly/blob/master/PanelOpener_IfPlayerStanding.cs)


בדיוק אותו דבר רק כשכאן נפתח הפאנל רק אם השחקן נמצא במצב עמידה.
הסקריפט הזה מקושר לCanvas/assetDetails/assetDetailsBTN , לכפתור של הshop.


[YourMoneyScript](https://github.com/shakedsh/Monopoly/blob/master/YourMoneyScript.cs)

הסקריפט שמראה כמה כסף יש לך, 
מקושר פעמיים ב Canvas/YourMoney   וב Canvas/bank/BankPanel/YourMoney

עכשיו יש שלושה סקריפטים פשוטים שכתבנו שמשתנים בPlayer_Movement בפונקציה CurrentTileUpdate :

[GroupScript](https://github.com/shakedsh/Monopoly/blob/master/GroupScript.cs)

[TileNameScript](https://github.com/shakedsh/Monopoly/blob/master/TileNameScript.cs)

[TileBuyingPriceScript](https://github.com/shakedsh/Monopoly/blob/master/TileBuyingPriceScript.cs)

בפאנל שעולה בלחיצה על הshop ומציג את פרטי הנכס  הם מעדכנים את הכיתוב של הקבוצה, השם של הנכס ומחיר הקניה שלו.
כולם מקושרים לעצמים הרלוונטים ב Canvas/assetDetails/AssetDetailsPanel

ובאותו מקום למטה מצד שמאל הכפתור של הקניה אליו מקושר הסקריפט האחרון
[BuyItScript](https://github.com/shakedsh/Monopoly/blob/master/BuyItScript.cs)
יש בו רק את הפונקציה   BuyAsset שבודקת האם יש לשחקן כסף ואז מורידה לו את עלות הנכס ומוסיפה את הנכס לרשימת הנכסים שלו  
  
</div>
