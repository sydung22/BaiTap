package com.example.contextmenu;

import androidx.annotation.NonNull;
import androidx.annotation.Nullable;
import androidx.appcompat.app.AppCompatActivity;

import android.content.Context;
import android.os.Bundle;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.AdapterView;
import android.widget.ArrayAdapter;
import android.widget.ImageView;
import android.widget.ListView;
import android.widget.TextView;
import android.widget.Toast;

public class MainActivity extends AppCompatActivity {

    ListView listView;
    String mTitle[] = {"Tạ tay Brosman", "Tạ tay Bowflex 1910", "Tạ tay Bowflex 552", "Bóng tạ thể hình", "Dây đàn hồi", "Dây thun kháng lực","Tạ tay Jodan","Găng tay thể hình"};
    String mDescription[] = {"Giá tiền: 525.000đ", "Giá tiền: 1.500.000d", "Giá tiền: 780.000d", "Giá tiền: 600.000đ", "Giá tiền: 820.000đ", "Giá tiền: 1.000.000đ","Giá tiền: 650.000","Giá tiền: 70.000đ"};
    int images[] = {R.drawable.br, R.drawable.bf, R.drawable.bf2, R.drawable.bt, R.drawable.ddh, R.drawable.dt,R.drawable.jd, R.drawable.gangtay};
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        listView = findViewById(R.id.listView);
        // now create an adapter class

        MyAdapter adapter = new MyAdapter(this, mTitle, mDescription, images);
        listView.setAdapter(adapter);
        // there is my mistake...
        // now again check this..

        // now set item click on list view
        listView.setOnItemClickListener(new AdapterView.OnItemClickListener() {
            @Override
            public void onItemClick(AdapterView<?> parent, View view, int position, long id) {
                if (position ==  0) {
                    Toast.makeText(MainActivity.this, "Tạ tay Brosman", Toast.LENGTH_SHORT).show();
                }
                if (position ==  1) {
                    Toast.makeText(MainActivity.this, "Tạ tay Bowflex 1910", Toast.LENGTH_SHORT).show();
                }
                if (position ==  2) {
                    Toast.makeText(MainActivity.this, "Tạ tay Bowflex 552", Toast.LENGTH_SHORT).show();
                }
                if (position ==  3) {
                    Toast.makeText(MainActivity.this, "Bóng tạ thể hình", Toast.LENGTH_SHORT).show();
                }
                if (position ==  4) {
                    Toast.makeText(MainActivity.this, "Dây đàn hồi", Toast.LENGTH_SHORT).show();
                }
                if (position ==  5) {
                    Toast.makeText(MainActivity.this, "Dây thun kháng lực", Toast.LENGTH_SHORT).show();
                }
            }
        });
        // so item click is done now check list view
    }

    class MyAdapter extends ArrayAdapter<String> {

        Context context;
        String rTitle[];
        String rDescription[];
        int rImgs[];

        MyAdapter (Context c, String title[], String description[], int imgs[]) {
            super(c, R.layout.row, R.id.textView1, title);
            this.context = c;
            this.rTitle = title;
            this.rDescription = description;
            this.rImgs = imgs;

        }

        @NonNull
        @Override
        public View getView(int position, @Nullable View convertView, @NonNull ViewGroup parent) {
            LayoutInflater layoutInflater = (LayoutInflater)getApplicationContext().getSystemService(Context.LAYOUT_INFLATER_SERVICE);
            View row = layoutInflater.inflate(R.layout.row, parent, false);
            ImageView images = row.findViewById(R.id.image);
            TextView myTitle = row.findViewById(R.id.textView1);
            TextView myDescription = row.findViewById(R.id.textView2);

            // now set our resources on views
            images.setImageResource(rImgs[position]);
            myTitle.setText(rTitle[position]);
            myDescription.setText(rDescription[position]);




            return row;
        }
    }
}
