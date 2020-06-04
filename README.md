# Monopoly
<p dir="rtl">כדי לזהות מתי נעצרה הקוביה אחרי שהסתיימה ההטלה, ניסינו בתחילה להתשמש ב ה OnCollisionEnter, אך עד מהרה גילינו שזה לא יעיל, מפני שהקוביה ממשיכה להתגלגל גם לאחר שפגעה באדמה<p>
  
<p dir="rtl">ניסינו באמצעות מהירות הקוביה, אך היות והיא לא נעצרת גם לאחר הנפילה, השתמשנו בנוסחה הבאה, כלומר מספיק שהמהירות תהיה קטנה מ 0.1<p>

```csharp
void Update()
{
    if (isCubeMoving && GetComponent<Rigidbody>().velocity.magnitude <= 0.1)
    {
        Debug.Log("stop"); // הקוביה הפסיקה לזוז
        isCubeMoving = false;
        regularDiceCount();
    }
}
```

<p dir="rtl">השלב הבא היה למצוא מהו הצד העליון. לשם כך נעזרנו בתכונה Vector3.up</p>

```csharp
// בדיקה אחרי שהקוביה נחתה, מה הצד העליון
void WhichSideUp()
{
    if (Vector3.Dot(-transform.up, Vector3.up) > 0.6f)
        diceCount = 1;
    if (Vector3.Dot(transform.forward, Vector3.up) > 0.6f)
        diceCount = 2;
    if (Vector3.Dot(transform.up, Vector3.up) > 0.6f)
        diceCount = 3;
    if (Vector3.Dot(-transform.forward, Vector3.up) > 0.6f)
        diceCount = 4;
    if (Vector3.Dot(transform.right, Vector3.up) > 0.6f)
        diceCount = 5;
    if (Vector3.Dot(-transform.right, Vector3.up) > 0.6f)
        diceCount = 6;
    Debug.Log("up = " + diceCount);
}
```
