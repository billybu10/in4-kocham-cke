package pl.edu.zse.inf4220601;

import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.TextView;

import androidx.activity.EdgeToEdge;
import androidx.appcompat.app.AppCompatActivity;
import androidx.core.graphics.Insets;
import androidx.core.view.ViewCompat;
import androidx.core.view.WindowInsetsCompat;

public class MainActivity extends AppCompatActivity {
    Button like;
    Button delete;
    TextView likeNumber;
    int likes = 0;

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

        like = findViewById(R.id.like);
        delete = findViewById(R.id.delete);
        likeNumber = findViewById(R.id.likeNumber);

        like.setOnClickListener(new View.OnClickListener() {
                @Override
                public void onClick(View view) {
                    likes++;
                    likeNumber.setText(likes + " polubień");
                }
            }
        );

        delete.setOnClickListener(new View.OnClickListener() {
                                    @Override
                                    public void onClick(View view) {
                                        if(likes > 0) {
                                            likes--;
                                        }
                                        likeNumber.setText(likes + " polubień");
                                    }
                                }
        );
    }
}