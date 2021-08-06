import javax.swing.*;
import java.awt.*;
import java.awt.event.*;

class Test{
		static JFrame f;
		static JLabel name;
		static JLabel level;
		static JTextField showName;
		static String str[];
		static JComboBox showLevel;
		static JButton go;
		static JProgressBar bar;
		static JLabel loading;
	
		static Boolean isLevelSelected;
		static String choice;
		static int x;
		
	public static void main(String args[]){
		startGame();
	}
	
	public static void startGame(){
		
		f=new JFrame("A step to Logic");
		name=new JLabel("Enter player Name: ");
		level=new JLabel("Select Game Level: ");
		showName=new JTextField();
		str=new String[]{"ChOOSE FROM HERE","EASY","MEDIUM","DIFFICULT"};
		showLevel=new JComboBox(str);	
		go=new JButton("Let's Start!");
		bar=new JProgressBar();
		loading=new JLabel("<html><font size=5 color=yellow>Loading Game for you .....");	
		choice="NONE";
		isLevelSelected=false;
		x=0;
		
		f.setSize(750,600);
		f.setLocationRelativeTo(null);
		f.setResizable(false);
		f.setDefaultCloseOperation(f.EXIT_ON_CLOSE);
		f.setLayout(null);
		f.getContentPane().setBackground(Color.MAGENTA);
		
		bar.setStringPainted(true);
		bar.setForeground(Color.GREEN);
		bar.setBackground(Color.MAGENTA);
			
		Font font=new Font("Courier",Font.BOLD,18);
		name.setBounds(100,100,220,30);
		showName.setBounds(320,100,250,30);
		level.setBounds(100,180,220,30);
		showLevel.setBounds(320,180,250,30);
		go.setBounds(320,270,250,30);
		loading.setBounds(320,340,250,30);	
		bar.setBounds(100,380,470,20);	
	
		bar.setBorderPainted(false);
		name.setLabelFor(showName);
		name.setDisplayedMnemonic('E');
		level.setLabelFor(showLevel);
		level.setDisplayedMnemonic('S');
		
		name.setFont(font);
		showName.setFont(font);
		level.setFont(font);
		
		showLevel.addItemListener(new Listener());
		go.addActionListener(new PerformAction());
		
		loading.setVisible(false);
			
		f.add(name);
		f.add(showName);
		f.add(level);
		f.add(showLevel);
		f.add(go);
		f.add(loading);	
		f.setVisible(true);
	}
}
class Listener extends Test implements ItemListener{

	public void itemStateChanged(ItemEvent ie){
		JComboBox item=(JComboBox)ie.getSource();
		if(item.getSelectedItem().toString().equals("EASY")){
			choice="EASY";
			isLevelSelected=true;
		}
		if(item.getSelectedItem().toString().equals("MEDIUM")){
			choice="MEDIUM";
			isLevelSelected=true;	
		}
		if(item.getSelectedItem().toString().equals("DIFFICULT")){
			choice="DIFFICULT";
			isLevelSelected=true;	
		}
		
	}
}
class PerformAction extends Listener implements Runnable, ActionListener{
	
	public void actionPerformed(ActionEvent ae){
		
		if(showName.getText().length()>0 && isLevelSelected==true){
			loading.setVisible(true);
			Thread th=new Thread(new PerformAction());
			th.start();				
		}
		else{
			JOptionPane.showMessageDialog(null,"Please provide Name and Select Level");
		}	
	}
	public void run(){
			
		while(x<=100){
			x++;		
			bar.setValue(x);
			try{Thread.sleep(20);}catch(Exception ex){}
			f.add(bar);
		}		
		if(x>100){
				f.dispose();
				Game.designGame(showName.getText(), choice);
		}		
	}
}