package pl.edu.zse.inf4240601;

import android.content.res.Resources;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.ImageView;
import android.widget.TextView;

import androidx.activity.EdgeToEdge;
import androidx.appcompat.app.AppCompatActivity;
import androidx.appcompat.content.res.AppCompatResources;
import androidx.core.content.ContextCompat;
import androidx.core.graphics.Insets;
import androidx.core.view.ViewCompat;
import androidx.core.view.WindowInsetsCompat;

import java.util.Random;

public class MainActivity extends AppCompatActivity {
    Button button;
    TextView textview;
    ImageView imageView;

    public int[] throwDices(int count){
        int[] outputVector = new int[count];
        Random r = new Random();
        for (int i = 0; i < count; i++)
        {
            outputVector[i] = r.nextInt(6)+1;
        }
        return outputVector;
    }

    public int countPoints(int[] rolledDicesValues){
        int points = 0;
        int[] amountEachNumberWasRolled = {0, 0, 0, 0, 0, 0};

        for(int value : rolledDicesValues){
            amountEachNumberWasRolled[value-1]++;
        }

        for (int i = 0; i < amountEachNumberWasRolled.length; i++)
        {
            if(amountEachNumberWasRolled[i] > 1){
                points += amountEachNumberWasRolled[i]*(i+1);
            }
        }

        return points;
    }

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        EdgeToEdge.enable(this);
        setContentView(R.layout.activity_main);
        ViewCompat.setOnApplyWindowInsetsListener(findViewById(R.id.main), (v, insets) -> {
            Insets systemBars = insets.getInsets(WindowInsetsCompat.Type.systemBars());
            v.setPadding(systemBars.left, systemBars.top, systemBars.right, systemBars.bottom);
            return insets;
        });

        button = findViewById(R.id.button);
        textview = findViewById(R.id.textView);
        imageView = findViewById(R.id.imageView);

        button.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                imageView.setImageResource(R.drawable.ic_launcher_foreground);
                textview.setText(String.valueOf(countPoints(throwDices(6))));

            }
        });

    }
}