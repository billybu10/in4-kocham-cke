package pl.edu.zse.inf4230602;

import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.SeekBar;
import android.widget.TextView;

import androidx.activity.EdgeToEdge;
import androidx.appcompat.app.AppCompatActivity;
import androidx.core.graphics.Insets;
import androidx.core.view.ViewCompat;
import androidx.core.view.WindowInsetsCompat;

public class MainActivity extends AppCompatActivity {
    SeekBar fontSize;
    Button nextMessage;
    TextView message, sizeTextView;
    String[] messages = {
            "Dzień dobry",
            "Good morning",
            "Buenos dias"
    };
    int currentMessageIndex = 0;

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

        fontSize = findViewById(R.id.fontSize);
        nextMessage = findViewById(R.id.nextMessage);
        message = findViewById(R.id.message);
        sizeTextView = findViewById(R.id.sizeTextView);

        fontSize.setOnSeekBarChangeListener(new SeekBar.OnSeekBarChangeListener() {
            @Override
            public void onProgressChanged(SeekBar seekBar, int i, boolean b) {

                sizeTextView.setText("Rozmiar: " + seekBar.getProgress());
                message.setTextSize(seekBar.getProgress());
            }

            @Override
            public void onStartTrackingTouch(SeekBar seekBar) {

            }

            @Override
            public void onStopTrackingTouch(SeekBar seekBar) {

            }
        });

        nextMessage.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                if (currentMessageIndex < 2){
                    currentMessageIndex++;
                }else{
                    currentMessageIndex = 0;
                }
                message.setText(messages[currentMessageIndex]);
            }
        });

    }
}